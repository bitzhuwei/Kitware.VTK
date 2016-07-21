using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCanvasSource2D : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCanvasSource2D";

		public new static readonly string MRClassNameKey;

		static vtkImageCanvasSource2D()
		{
			vtkImageCanvasSource2D.MRClassNameKey = "class vtkImageCanvasSource2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCanvasSource2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCanvasSource2D"));
		}

		public vtkImageCanvasSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCanvasSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCanvasSource2D New()
		{
			vtkImageCanvasSource2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCanvasSource2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCanvasSource2D.vtkImageCanvasSource2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawCircle_01(HandleRef pThis, int c0, int c1, double radius);

		public void DrawCircle(int c0, int c1, double radius)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawCircle_01(base.GetCppThis(), c0, c1, radius);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawImage_02(HandleRef pThis, int x0, int y0, HandleRef i);

		public void DrawImage(int x0, int y0, vtkImageData i)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawImage_02(base.GetCppThis(), x0, y0, (i == null) ? default(HandleRef) : i.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawImage_03(HandleRef pThis, int x0, int y0, HandleRef arg2, int sx, int sy, int width, int height);

		public void DrawImage(int x0, int y0, vtkImageData arg2, int sx, int sy, int width, int height)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawImage_03(base.GetCppThis(), x0, y0, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), sx, sy, width, height);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawPoint_04(HandleRef pThis, int p0, int p1);

		public void DrawPoint(int p0, int p1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawPoint_04(base.GetCppThis(), p0, p1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawSegment_05(HandleRef pThis, int x0, int y0, int x1, int y1);

		public void DrawSegment(int x0, int y0, int x1, int y1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment_05(base.GetCppThis(), x0, y0, x1, y1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawSegment3D_06(HandleRef pThis, IntPtr p0, IntPtr p1);

		public void DrawSegment3D(IntPtr p0, IntPtr p1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment3D_06(base.GetCppThis(), p0, p1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_DrawSegment3D_07(HandleRef pThis, double x1, double y1, double z1, double x2, double y2, double z2);

		public void DrawSegment3D(double x1, double y1, double z1, double x2, double y2, double z2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment3D_07(base.GetCppThis(), x1, y1, z1, x2, y2, z2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_FillBox_08(HandleRef pThis, int min0, int max0, int min1, int max1);

		public void FillBox(int min0, int max0, int min1, int max1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillBox_08(base.GetCppThis(), min0, max0, min1, max1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_FillPixel_09(HandleRef pThis, int x, int y);

		public void FillPixel(int x, int y)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillPixel_09(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_FillTriangle_10(HandleRef pThis, int x0, int y0, int x1, int y1, int x2, int y2);

		public void FillTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillTriangle_10(base.GetCppThis(), x0, y0, x1, y1, x2, y2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_FillTube_11(HandleRef pThis, int x0, int y0, int x1, int y1, double radius);

		public void FillTube(int x0, int y0, int x1, int y1, double radius)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillTube_11(base.GetCppThis(), x0, y0, x1, y1, radius);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCanvasSource2D_GetDefaultZ_12(HandleRef pThis);

		public virtual int GetDefaultZ()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDefaultZ_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCanvasSource2D_GetDrawColor_13(HandleRef pThis);

		public virtual double[] GetDrawColor()
		{
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_GetDrawColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetDrawColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_GetDrawColor_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetDrawColor(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCanvasSource2D_GetNumberOfScalarComponents_16(HandleRef pThis);

		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetNumberOfScalarComponents_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCanvasSource2D_GetRatio_17(HandleRef pThis);

		public virtual double[] GetRatio()
		{
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_GetRatio_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetRatio(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_GetRatio_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetRatio(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCanvasSource2D_GetScalarType_20(HandleRef pThis);

		public int GetScalarType()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetScalarType_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCanvasSource2D_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCanvasSource2D_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCanvasSource2D_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCanvasSource2D NewInstance()
		{
			vtkImageCanvasSource2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCanvasSource2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCanvasSource2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageCanvasSource2D vtkImageCanvasSource2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCanvasSource2D = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCanvasSource2D.Register(null);
				}
			}
			return vtkImageCanvasSource2D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDefaultZ_26(HandleRef pThis, int _arg);

		public virtual void SetDefaultZ(int _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDefaultZ_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_27(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetDrawColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_27(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_28(HandleRef pThis, IntPtr _arg);

		public virtual void SetDrawColor(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_29(HandleRef pThis, double a);

		public void SetDrawColor(double a)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_29(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_30(HandleRef pThis, double a, double b);

		public void SetDrawColor(double a, double b)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_30(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_31(HandleRef pThis, double a, double b, double c);

		public void SetDrawColor(double a, double b, double c)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_31(base.GetCppThis(), a, b, c);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetExtent_32(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetExtent_32(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetExtent_33(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetExtent_33(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetNumberOfScalarComponents_34(HandleRef pThis, int i);

		public virtual void SetNumberOfScalarComponents(int i)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetNumberOfScalarComponents_34(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetRatio_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetRatio(double _arg1, double _arg2, double _arg3)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetRatio_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetRatio_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetRatio(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetRatio_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarType_37(HandleRef pThis, int arg0);

		public void SetScalarType(int arg0)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarType_37(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToChar_38(HandleRef pThis);

		public void SetScalarTypeToChar()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToChar_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToDouble_39(HandleRef pThis);

		public void SetScalarTypeToDouble()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToDouble_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToFloat_40(HandleRef pThis);

		public void SetScalarTypeToFloat()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToFloat_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToInt_41(HandleRef pThis);

		public void SetScalarTypeToInt()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToInt_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToLong_42(HandleRef pThis);

		public void SetScalarTypeToLong()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToLong_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToShort_43(HandleRef pThis);

		public void SetScalarTypeToShort()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToShort_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_44(HandleRef pThis);

		public void SetScalarTypeToUnsignedChar()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_45(HandleRef pThis);

		public void SetScalarTypeToUnsignedInt()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_46(HandleRef pThis);

		public void SetScalarTypeToUnsignedLong()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_47(HandleRef pThis);

		public void SetScalarTypeToUnsignedShort()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_47(base.GetCppThis());
		}
	}
}
