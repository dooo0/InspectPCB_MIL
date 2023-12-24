using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrox.Imaging.ObjectMil;
using Matrox.MatroxImagingLibrary;

namespace Vision.MIL_Control
{
    internal class MIL_ImageControl
    {
        public MIL_ID mil_MainImage = MIL.M_NULL;
        public MIL_ID mil_DisplayImage = MIL.M_NULL;
        public MIL_ID milDisplay = MIL.M_NULL;

        public double Zoom = 1;
        private const double Zoom_Min = 1;
        private double Zoom_Max = 70;
        private double ZoomScope = 1;

        private Size Size_Display
        {
            get
            {
                return new Size(Width_Display, Height_Display);
            }
            set
            {
                Width_Display = value.Width;
                Height_Display = value.Height;
            }
        }
        private Size Size_Image
        {
            get 
            { 
                return new Size(Width_Image, Height_Image);
            }
            set 
            { 
                Width_Image = value.Width;
                Height_Image = value.Height;
            }
        }

        private int Width_Display;
        private int Height_Display;
        private int Width_Image;
        private int Height_Image;

        private double ViewRatio = 1;
        private Point pt_pos = new Point(0, 0);
        private Point pt_offset = new Point(0, 0);

        private bool WidthView = false;
        public bool DrawMode
        {
            get
            {
                return Global.Common.TeachingMode;
            }
            set
            {
                Global.Common.TeachingMode = value;
            }
        }

        //private MIL_GRA_HOOK_FUNCTION_PTR HookHandlerDelegate;

        public MIL_ImageControl(Size disp, Size image)
        {
            Width_Display = disp.Width;
            Height_Display = disp.Height;
            Width_Image = image.Width;
            Height_Image = image.Height;

            Size_Display = new Size(Width_Display, Height_Display);
            Size_Image = new Size(Width_Image, Height_Image);

            ToggleViewMode_WH(false);
        }

        public void Set_Display_Size(Size sz)
        {
            Size_Display = sz;
            Width_Display = sz.Width;
            Height_Display = sz.Height;
            ToggleViewMode_WH(WidthView);
        }

        public void SetPos(Point pt)
        {
            pt_pos.X = pt.X;
            pt_pos.Y = pt.Y;
        }

        public Point GetPos()
        {
            return pt_pos;
        }

        public void SetTeachingMode(bool Draw)
        {
            if(Draw)
            {
                pt_pos.X = 0;
                pt_pos.Y = 0;
            }
            ToggleViewMode_WH(WidthView);
            this.Draw();           
            

            DrawMode = Draw;

            return;
        }

        public static MIL_INT GraphicListModifiedHookFct(MIL_INT HookType, MIL_ID EventID, IntPtr UserDataPtr)
        {
            MIL_INT State = MIL.M_NULL;
            MIL_INT Type = HookType;

            if (UserDataPtr != MIL.M_NULL && Type != MIL.M_NULL)
            {
                MIL.MgraGetHookInfo(EventID, MIL.M_GRAPHIC_LABEL_VALUE, ref State);
        
                if ((State != MIL.M_STATE_WAITING_FOR_CREATION) && (State != MIL.M_STATE_BEING_CREATED))
                {
                    //MIL_INT.WriteMilInt(UserDataPtr, MIL.M_NULL);
                }
            }
            return MIL.M_NULL; 
        }

        public void ToggleViewMode_WH(bool bWidthView)
        {
            WidthView = bWidthView;

            double w = (double)Size_Display.Width / (double)Size_Image.Width;
            double h = (double)Size_Display.Height / (double)Size_Image.Height;

            double dScalRatio = (double)Height_Image / (double)Height_Display;
            double dwidth = Width_Display * dScalRatio;
            double dOffsetX = (double)((dwidth - Width_Image) / 2);

            ViewRatio = bWidthView ? w : h;
            pt_offset.X = bWidthView ? 0 : (int)dOffsetX;
        }

        public double GetZoomScale()
        {
            double scale;

            scale = Zoom * ViewRatio;

            return scale;
        }

        public void LoadImage(string Path)
        {
            MIL.MbufClear(mil_MainImage, 0);
            MIL.MbufClear(mil_DisplayImage, 0);
            //MIL.MdispControl(milDisplay, MIL.M_OVERLAY_CLEAR, MIL.M_DEFAULT);

            MIL.MbufLoad(Path, mil_MainImage);
            MIL.MbufLoad(Path, mil_DisplayImage);

            MIL.MbufInquire(mil_MainImage, MIL.M_SIZE_X, ref Width_Image);
            MIL.MbufInquire(mil_MainImage, MIL.M_SIZE_Y, ref Height_Image);

            Zoom = 1;
            double scale = GetZoomScale();
            MIL.MdispZoom(milDisplay, scale, scale);
          
        }


        public void Zoom_In(Point pt_mouse)
        {
            Point ptImgRB = new Point(Size_Display.Width -1, Size_Display.Height-1);
            ptImgRB = ViewPt_to_ImagePt(ptImgRB,1);

            if (Zoom + 0.1 < Zoom_Max)
            {      
                double dCurZoom = Zoom;
                Zoom += ZoomScope;

                double LastViewWidth = (double)ptImgRB.X / dCurZoom;
                double LastViewHeight = (double)ptImgRB.Y / dCurZoom;

                double ZoomedViewWidth = (double)ptImgRB.X / Zoom;
                double ZoomedViewHeight = (double)ptImgRB.Y / Zoom;

                double XRatio = (double)pt_mouse.X / (double)(Width_Display - 1);
                double YRatio = (double)pt_mouse.Y / (double)(Height_Display- 1);

                double XCalc = (double)(LastViewWidth - ZoomedViewWidth) * XRatio;
                double YCalc = (double)(LastViewHeight - ZoomedViewHeight) * YRatio;

                Point pt = new Point((int)Math.Round(XCalc), (int)Math.Round(YCalc));

                pt_pos.X = (int)(pt_pos.X) + pt.X;
                pt_pos.Y = (int)(pt_pos.Y) + pt.Y;
            }
            else
            {
                Zoom = Zoom_Max;
            }

            Draw();
        }

        public void Zoom_Out(Point pt_mouse)
        {
            Point ptImgRB = new Point(Size_Display.Width, Size_Display.Height);
            ptImgRB = ViewPt_to_ImagePt(ptImgRB,1);

            if (Zoom - 0.1 > Zoom_Min)
            {
                double dCurZoom = Zoom;
                Zoom -= ZoomScope;

                double LastViewWidth = (double)ptImgRB.X / dCurZoom;
                double LastViewHeight = (double)ptImgRB.Y / dCurZoom;

                double ZoomedViewWidth = (double)ptImgRB.X / Zoom;
                double ZoomedViewHeight = (double)ptImgRB.Y / Zoom;

                double XRatio = (double)pt_mouse.X / (double)(Width_Display - 1);
                double YRatio = (double)pt_mouse.Y / (double)(Height_Display - 1);

                double XCalc = (double)(LastViewWidth - ZoomedViewWidth) * XRatio;
                double YCalc = (double)(LastViewHeight - ZoomedViewHeight) * YRatio;

                Point pt = new Point((int)Math.Round(XCalc), (int)Math.Round(YCalc));

                pt_pos.X = (int)(pt_pos.X) + pt.X;
                pt_pos.Y = (int)(pt_pos.Y) + pt.Y;
            }
            else
            {
                Zoom = Zoom_Min;

                if(WidthView)
                {
                    pt_pos.X = 0;
                    pt_pos.Y = 0;
                }
                else
                {
                    pt_pos.X = 0;
                    pt_pos.Y = 0;
                }
            }

            Draw();
        }

        public void SetDrawMode_Rectangle()
        {
           
        }

        public void EndMIL()
        { 
            // Free allocated objects.            
            MIL.MbufFree(mil_MainImage);
            MIL.MbufFree(mil_DisplayImage);
        }

        public Point ImagePt_To_ViewPt(Point Point)
        {
            double dScalRatio;


            if (WidthView)
                dScalRatio = (double)(Width_Display - 1) / (double)Width_Image;
            else
                dScalRatio = (double)(Height_Display - 1) / (double)Height_Image;

            Point.X = (int)(Point.X * dScalRatio * Zoom) - (int)(pt_offset.X * dScalRatio);
            Point.Y = (int)(Point.Y * dScalRatio * Zoom) - (int)(pt_offset.Y * dScalRatio);

            return Point;
        }

        public Point ViewPt_to_ImagePt(Point Point)
        {
            double dScalRatio;

            if (WidthView)
            {
                dScalRatio = (double)Width_Image / (double)(Width_Display-1);
            }
            else
            {
                dScalRatio = (double)Height_Image / (double)(Height_Display-1);
            }

            Point.X = (int)((Point.X * dScalRatio) / Zoom) - (int)((pt_offset.X - pt_pos.X));
            Point.Y = (int)((Point.Y * dScalRatio) / Zoom) - (int)((pt_offset.Y - pt_pos.Y));

            return Point;
        }

        public Point ViewPt_to_ImagePt(Point Point, double dZoom)
        {
            double dScalRatio;

            if (WidthView)
            {
                dScalRatio = (double)Width_Image / (double)(Width_Display - 1);
            }
            else
            {
                dScalRatio = (double)Height_Image / (double)(Height_Display - 1);
            }

            Point.X = (int)((Point.X * dScalRatio) / dZoom);// - (int)((pt_offset.X -));
            Point.Y = (int)((Point.Y * dScalRatio) / dZoom);// - (int)((pt_offset.Y -));

            return Point;
        }

        public void Draw()
        {
            double scale =  GetZoomScale();
            
            MIL.MdispZoom(milDisplay, scale, scale);
            MIL.MdispPan(milDisplay, pt_pos.X - pt_offset.X, pt_pos.Y - pt_offset.Y);
        }

        public void Set_ZeroPosition()
        {
            Zoom = Zoom_Min;

            pt_pos.X = 0;
            pt_pos.Y = 0;

            Draw();
        }
    } 
}
