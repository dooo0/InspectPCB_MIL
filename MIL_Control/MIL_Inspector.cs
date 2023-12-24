using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.ROI;
using System.Drawing;
using Matrox.MatroxImagingLibrary;
using Global;
using static Matrox.Imaging.ObjectMil.Mod;
using static Matrox.Imaging.ObjectMil.Disp;
using Vision.ROI.Inspect_Module;
using System.Xml.Serialization;

namespace Vision.MIL_Control
{
    public class MIL_Inspector
    {

        public Dictionary<RegionType, ROI.ROI> RegionList;

        public MIL_ID milSystem = MIL.M_NULL;
        public MIL_ID milDisplay = MIL.M_NULL;
        public MIL_ID milGraphicContext = MIL.M_NULL;
        public MIL_ID milGraphicList = MIL.M_NULL;
        public MIL_ID mil_MainImage = MIL.M_NULL;
        public MIL_ID mil_DisplayImage = MIL.M_NULL;
        public MIL_ID milOverlayImage = MIL.M_NULL;
        public MIL_ID MilBlobContext = MIL.M_NULL;
        public MIL_ID milMaskImage = MIL.M_NULL;

        public MIL_Inspector(ref Dictionary<RegionType, ROI.ROI> rgn)
        {
            RegionList = rgn;
        }

        ~MIL_Inspector()
        {

        }


        public void Init(MIL_Display disp)
        {
            milSystem = disp.milSystem;
            milDisplay = disp.milDisplay;
            mil_MainImage = disp.mil_MainImage;
            mil_DisplayImage = disp.mil_DisplayImage;
            milGraphicContext = disp.milGraphicContext;
            milGraphicList = disp.milGraphicList;
            milOverlayImage = disp.milOverlayImage;
            milMaskImage = disp.milMaskImage;

            MIL.MblobAlloc(milSystem, MIL.M_DEFAULT, MIL.M_DEFAULT, ref MilBlobContext);
            MIL.MblobControl(MilBlobContext, MIL.M_CENTER_OF_GRAVITY + MIL.M_BINARY, MIL.M_ENABLE);

            double x = 0; double y = 0;
            MIL.MdispInquire(milDisplay, MIL.M_SIZE_X, ref x);
            MIL.MdispInquire(milDisplay, MIL.M_SIZE_Y, ref y);
        }

        public void EndMIL()
        {
            MIL.MblobFree(MilBlobContext);
        }

        public bool Inspect()
        {
            MIL.MdispControl(milDisplay, MIL.M_OVERLAY_CLEAR, MIL.M_DEFAULT);

            MIL.MbufFree(milMaskImage);
            MIL.MbufAlloc2d(milSystem, 8192, 20000, 1 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_PROC, ref milMaskImage);

            foreach (var region in RegionList)
            {
                foreach (var child in region.Value.ChildRegion)
                {
                    if (child is BinaryInspect)
                    {
                        Inspect_Binary(child as BinaryInspect);
                    }
                    else if (child is Inspect_MapID_Outside)
                    {
                        Inspect_MapID(child as Inspect_MapID_Outside);
                    }
                }
            }

            MIL.MbufClearCond(milOverlayImage, 255, 0, 0, milMaskImage, MIL.M_NOT_EQUAL, 0);
            return false;
        }

        private void Inspect_Binary(BinaryInspect Region)
        {
            int XCount = ((Inspect_Area)RegionList[RegionType.Area].ChildRegion[0]).X_Count;
            int YCount = ((Inspect_Area)RegionList[RegionType.Area].ChildRegion[0]).Y_Count;
            double StripWidth = ((Inspect_Area)RegionList[RegionType.Area].ChildRegion[0]).StripWidth;
            double StripHeight = ((Inspect_Area)RegionList[RegionType.Area].ChildRegion[0]).StripHeight;

            for (int i = 0; i < YCount; i++)
            {
                for (int j = 0; j < XCount; j++)
                {
                    MIL_ID MilBinImage = MIL.M_NULL;
                    MIL_ID MilBlobResult = MIL.M_NULL;
                    MIL_ID MilMaskChildImage = MIL.M_NULL;

                    MIL.MbufChild2d(milMaskImage, (int)(Region.X + (j % XCount * StripWidth)), (int)(Region.Y + (i % YCount * StripHeight)), (int)Region.Width, (int)Region.Height, ref MilMaskChildImage);

                    MIL.MbufAllocColor(milSystem, 1, (int)Region.Width, (int)Region.Height, 8 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_PROC + MIL.M_DISP, ref MilBinImage);
                    MIL.MbufCopyColor2d(mil_DisplayImage, MilBinImage, MIL.M_ALL_BANDS, (int)(Region.X + (j % XCount * StripWidth)), (int)(Region.Y + (i % YCount * StripHeight)), MIL.M_ALL_BANDS, 0, 0, (int)Region.Width, (int)Region.Height);

                    //MIL.MimBinarize(MilBinImage, MilBinImage, MIL.M_FIXED + MIL.M_IN_RANGE, Region.Threshold_Min, Region.Threshold_Max);
                    MIL.MimBinarize(MilBinImage, MilBinImage, MIL.M_FIXED + MIL.M_IN_RANGE, 80, Region.GV_Max);

                    // Allocate a blob result buffer.
                    MIL.MblobAllocResult(milSystem, MIL.M_DEFAULT, MIL.M_DEFAULT, ref MilBlobResult);

                    // Calculate selected features for each blob.
                    MIL.MblobCalculate(MilBlobContext, MilBinImage, MIL.M_NULL, MilBlobResult);

                    // Exclude blobs whose area is too small.
                    MIL.MblobSelect(MilBlobResult, MIL.M_EXCLUDE, MIL.M_AREA, MIL.M_LESS_OR_EQUAL, 50, MIL.M_NULL);
                    //MIL.MblobSelect(MilBlobResult, MIL.M_EXCLUDE, MIL.M_LENGTH, MIL.M_LESS_OR_EQUAL, 50, MIL.M_NULL);

                    MIL_INT TotalBlobs = 0;
                    MIL.MblobGetResult(MilBlobResult, MIL.M_DEFAULT, MIL.M_NUMBER + MIL.M_TYPE_MIL_INT, ref TotalBlobs);

                    double[] CogArea = new double[TotalBlobs];
                    double[] TestArea = new double[TotalBlobs];
                    if (TotalBlobs > 0)
                    {
                        MIL.MblobGetResult(MilBlobResult, MIL.M_DEFAULT, MIL.M_AREA, CogArea);
                        //MIL.MblobGetResult(MilBlobResult, MIL.M_DEFAULT, MIL.M_LENGTH, TestArea);

                        for (int k = 0; k < CogArea.Length; k++)
                        {
                            if (Region.Area_Min <= CogArea[k] && CogArea[k] <= Region.Area_Max)
                            {
                                MIL.MgraText(milGraphicContext, milGraphicList, (Region.X + (j % XCount * StripWidth)), (Region.Y + (i % YCount * StripHeight)) + Region.Height, string.Format("Error Area : {0}", CogArea[k]));
                                MIL.MgraRect(milGraphicContext, milGraphicList, (Region.X + (j % XCount * StripWidth)), (Region.Y + (i % YCount * StripHeight)), (Region.X + (j % XCount * StripWidth)) + Region.Width, (Region.Y + (i % YCount * StripHeight)) + Region.Height);
                                MIL.MbufCopy(MilBinImage, MilMaskChildImage);
                                break;
                            }
                        }
                    }

                    MIL.MbufFree(MilBinImage);
                    MIL.MblobFree(MilBlobResult);
                    MIL.MbufFree(MilMaskChildImage);
                }
            }
        }

        private void Inspect_MapID(Inspect_MapID_Outside Region)
        {

        }
    }
}
