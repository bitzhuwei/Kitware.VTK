using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSectorSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSectorSource";

		public new static readonly string MRClassNameKey;

		static vtkSectorSource()
		{
			vtkSectorSource.MRClassNameKey = "class vtkSectorSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSectorSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSectorSource"));
		}

		public vtkSectorSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSectorSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSectorSource New()
		{
			vtkSectorSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSectorSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSectorSource.vtkSectorSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetCircumferentialResolution_01(HandleRef pThis);

		public virtual int GetCircumferentialResolution()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolution_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolutionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolutionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetEndAngle_04(HandleRef pThis);

		public virtual double GetEndAngle()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngle_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetEndAngleMaxValue_05(HandleRef pThis);

		public virtual double GetEndAngleMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngleMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetEndAngleMinValue_06(HandleRef pThis);

		public virtual double GetEndAngleMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngleMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetInnerRadius_07(HandleRef pThis);

		public virtual double GetInnerRadius()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetInnerRadiusMaxValue_08(HandleRef pThis);

		public virtual double GetInnerRadiusMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadiusMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetInnerRadiusMinValue_09(HandleRef pThis);

		public virtual double GetInnerRadiusMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadiusMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetOuterRadius_10(HandleRef pThis);

		public virtual double GetOuterRadius()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadius_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetOuterRadiusMaxValue_11(HandleRef pThis);

		public virtual double GetOuterRadiusMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadiusMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetOuterRadiusMinValue_12(HandleRef pThis);

		public virtual double GetOuterRadiusMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadiusMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetRadialResolution_13(HandleRef pThis);

		public virtual int GetRadialResolution()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolution_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetRadialResolutionMaxValue_14(HandleRef pThis);

		public virtual int GetRadialResolutionMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolutionMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_GetRadialResolutionMinValue_15(HandleRef pThis);

		public virtual int GetRadialResolutionMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolutionMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetStartAngle_16(HandleRef pThis);

		public virtual double GetStartAngle()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngle_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetStartAngleMaxValue_17(HandleRef pThis);

		public virtual double GetStartAngleMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngleMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetStartAngleMinValue_18(HandleRef pThis);

		public virtual double GetStartAngleMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngleMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetZCoord_19(HandleRef pThis);

		public virtual double GetZCoord()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoord_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetZCoordMaxValue_20(HandleRef pThis);

		public virtual double GetZCoordMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoordMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSectorSource_GetZCoordMinValue_21(HandleRef pThis);

		public virtual double GetZCoordMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoordMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSectorSource.vtkSectorSource_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSectorSource_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSectorSource.vtkSectorSource_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSectorSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSectorSource NewInstance()
		{
			vtkSectorSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSectorSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSectorSource SafeDownCast(vtkObjectBase o)
		{
			vtkSectorSource vtkSectorSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSectorSource = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSectorSource.Register(null);
				}
			}
			return vtkSectorSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetCircumferentialResolution_27(HandleRef pThis, int _arg);

		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkSectorSource.vtkSectorSource_SetCircumferentialResolution_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetEndAngle_28(HandleRef pThis, double _arg);

		public virtual void SetEndAngle(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetEndAngle_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetInnerRadius_29(HandleRef pThis, double _arg);

		public virtual void SetInnerRadius(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetInnerRadius_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetOuterRadius_30(HandleRef pThis, double _arg);

		public virtual void SetOuterRadius(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetOuterRadius_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetRadialResolution_31(HandleRef pThis, int _arg);

		public virtual void SetRadialResolution(int _arg)
		{
			vtkSectorSource.vtkSectorSource_SetRadialResolution_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetStartAngle_32(HandleRef pThis, double _arg);

		public virtual void SetStartAngle(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetStartAngle_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSectorSource_SetZCoord_33(HandleRef pThis, double _arg);

		public virtual void SetZCoord(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetZCoord_33(base.GetCppThis(), _arg);
		}
	}
}
