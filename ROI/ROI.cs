using Global;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vision.ROI
{
    [Serializable]
    public class ROI
    {
        public double X;
        public double Y;
        public double Width;   
        public double Height;
        public Color Color;

        public List<ROI> ChildRegion;
        public RegionType Type;

        public ROI()
        {
            ChildRegion = new List<ROI>();

            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;

            Color = Color.Blue;
            Type = RegionType.None;
        }

        public void Draw()
        {

        }

        public void Add_ChildRegion(ROI rgn)
        {
            ChildRegion.Add(rgn);
        }

        virtual public void Create_ChildRegion_From_Point(double x,double y,double width,double height)
        {
            ROI rgn = new ROI()
            {
                X = x,
                Y = y,
                Width = width,
                Height = height
            };

            ChildRegion.Add(rgn); 
        }

        public int GetChildRegionCount()
        {
            return ChildRegion.Count;
        }

        public void Clear_ChildRegion()
        {
            ChildRegion.Clear();
        }

        public int Get_ChildRegion_Count()
        {
            return ChildRegion.Count;
        }

        virtual public void Load(BinaryReader fs)
        {
            X = fs.ReadDouble();
            Y = fs.ReadDouble();
            Width = fs.ReadDouble();
            Height = fs.ReadDouble(); 

            return;
        }

        virtual public void Save(BinaryWriter fs)
        {
            fs.Write(X);
            fs.Write(Y);
            fs.Write(Width);
            fs.Write(Height);

            return;
        }

    }
}
