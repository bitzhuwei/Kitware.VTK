using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlyphSource2D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyphSource2D";

		public new static readonly string MRClassNameKey;

		static vtkGlyphSource2D()
		{
			vtkGlyphSource2D.MRClassNameKey = "class vtkGlyphSource2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyphSource2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyphSource2D"));
		}

		public vtkGlyphSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyphSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyphSource2D New()
		{
			vtkGlyphSource2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlyphSource2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlyphSource2D.vtkGlyphSource2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_CrossOff_01(HandleRef pThis);

		public virtual void CrossOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_CrossOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_CrossOn_02(HandleRef pThis);

		public virtual void CrossOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_CrossOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_DashOff_03(HandleRef pThis);

		public virtual void DashOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DashOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_DashOn_04(HandleRef pThis);

		public virtual void DashOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_DashOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_FilledOff_05(HandleRef pThis);

		public virtual void FilledOff()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_FilledOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_FilledOn_06(HandleRef pThis);

		public virtual void FilledOn()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_FilledOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyphSource2D_GetCenter_07(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_GetCenter_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_GetCenter_08(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_GetCenter_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyphSource2D_GetColor_09(HandleRef pThis);

		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_GetColor_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_GetColor_10(HandleRef pThis, IntPtr data);

		public virtual void GetColor(IntPtr data)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_GetColor_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetCross_11(HandleRef pThis);

		public virtual int GetCross()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetCross_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetDash_12(HandleRef pThis);

		public virtual int GetDash()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetDash_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetFilled_13(HandleRef pThis);

		public virtual int GetFilled()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetFilled_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetGlyphType_14(HandleRef pThis);

		public virtual int GetGlyphType()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphType_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetGlyphTypeMaxValue_15(HandleRef pThis);

		public virtual int GetGlyphTypeMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphTypeMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_GetGlyphTypeMinValue_16(HandleRef pThis);

		public virtual int GetGlyphTypeMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetGlyphTypeMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetRotationAngle_17(HandleRef pThis);

		public virtual double GetRotationAngle()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetRotationAngle_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScale_18(HandleRef pThis);

		public virtual double GetScale()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScale2_19(HandleRef pThis);

		public virtual double GetScale2()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScale2MaxValue_20(HandleRef pThis);

		public virtual double GetScale2MaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2MaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScale2MinValue_21(HandleRef pThis);

		public virtual double GetScale2MinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScale2MinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScaleMaxValue_22(HandleRef pThis);

		public virtual double GetScaleMaxValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScaleMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyphSource2D_GetScaleMinValue_23(HandleRef pThis);

		public virtual double GetScaleMinValue()
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_GetScaleMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyphSource2D_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlyphSource2D.vtkGlyphSource2D_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyphSource2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlyphSource2D NewInstance()
		{
			vtkGlyphSource2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyphSource2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyphSource2D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyphSource2D vtkGlyphSource2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyphSource2D.vtkGlyphSource2D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyphSource2D = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyphSource2D.Register(null);
				}
			}
			return vtkGlyphSource2D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetCenter_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCenter_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetCenter_30(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCenter_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetColor_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetColor_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetColor_32(HandleRef pThis, IntPtr _arg);

		public virtual void SetColor(IntPtr _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetColor_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetCross_33(HandleRef pThis, int _arg);

		public virtual void SetCross(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetCross_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetDash_34(HandleRef pThis, int _arg);

		public virtual void SetDash(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetDash_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetFilled_35(HandleRef pThis, int _arg);

		public virtual void SetFilled(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetFilled_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphType_36(HandleRef pThis, int _arg);

		public virtual void SetGlyphType(int _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphType_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToArrow_37(HandleRef pThis);

		public void SetGlyphTypeToArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToArrow_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToCircle_38(HandleRef pThis);

		public void SetGlyphTypeToCircle()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToCircle_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToCross_39(HandleRef pThis);

		public void SetGlyphTypeToCross()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToCross_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToDash_40(HandleRef pThis);

		public void SetGlyphTypeToDash()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToDash_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToDiamond_41(HandleRef pThis);

		public void SetGlyphTypeToDiamond()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToDiamond_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_42(HandleRef pThis);

		public void SetGlyphTypeToEdgeArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToHookedArrow_43(HandleRef pThis);

		public void SetGlyphTypeToHookedArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToHookedArrow_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToNone_44(HandleRef pThis);

		public void SetGlyphTypeToNone()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToNone_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToSquare_45(HandleRef pThis);

		public void SetGlyphTypeToSquare()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToSquare_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickArrow_46(HandleRef pThis);

		public void SetGlyphTypeToThickArrow()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToThickArrow_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickCross_47(HandleRef pThis);

		public void SetGlyphTypeToThickCross()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToThickCross_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToTriangle_48(HandleRef pThis);

		public void SetGlyphTypeToTriangle()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToTriangle_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetGlyphTypeToVertex_49(HandleRef pThis);

		public void SetGlyphTypeToVertex()
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetGlyphTypeToVertex_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetRotationAngle_50(HandleRef pThis, double _arg);

		public virtual void SetRotationAngle(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetRotationAngle_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetScale_51(HandleRef pThis, double _arg);

		public virtual void SetScale(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetScale_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyphSource2D_SetScale2_52(HandleRef pThis, double _arg);

		public virtual void SetScale2(double _arg)
		{
			vtkGlyphSource2D.vtkGlyphSource2D_SetScale2_52(base.GetCppThis(), _arg);
		}
	}
}
