using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConeSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConeSource";

		public new static readonly string MRClassNameKey;

		static vtkConeSource()
		{
			vtkConeSource.MRClassNameKey = "class vtkConeSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeSource"));
		}

		public vtkConeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConeSource New()
		{
			vtkConeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeSource.vtkConeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConeSource.vtkConeSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkConeSource.vtkConeSource_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkConeSource.vtkConeSource_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetAngle_03(HandleRef pThis);

		public double GetAngle()
		{
			return vtkConeSource.vtkConeSource_GetAngle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_GetCapping_04(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkConeSource.vtkConeSource_GetCapping_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConeSource_GetCenter_05(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkConeSource.vtkConeSource_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_GetCenter_06(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkConeSource.vtkConeSource_GetCenter_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConeSource_GetDirection_07(HandleRef pThis);

		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkConeSource.vtkConeSource_GetDirection_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_GetDirection_08(HandleRef pThis, IntPtr data);

		public virtual void GetDirection(IntPtr data)
		{
			vtkConeSource.vtkConeSource_GetDirection_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetHeight_09(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkConeSource.vtkConeSource_GetHeight_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetHeightMaxValue_10(HandleRef pThis);

		public virtual double GetHeightMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetHeightMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetHeightMinValue_11(HandleRef pThis);

		public virtual double GetHeightMinValue()
		{
			return vtkConeSource.vtkConeSource_GetHeightMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetRadius_12(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkConeSource.vtkConeSource_GetRadius_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetRadiusMaxValue_13(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetRadiusMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkConeSource_GetRadiusMinValue_14(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkConeSource.vtkConeSource_GetRadiusMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_GetResolution_15(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkConeSource.vtkConeSource_GetResolution_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_GetResolutionMaxValue_16(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkConeSource.vtkConeSource_GetResolutionMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_GetResolutionMinValue_17(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkConeSource.vtkConeSource_GetResolutionMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConeSource.vtkConeSource_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConeSource_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConeSource.vtkConeSource_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConeSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConeSource NewInstance()
		{
			vtkConeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeSource.vtkConeSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConeSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConeSource SafeDownCast(vtkObjectBase o)
		{
			vtkConeSource vtkConeSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeSource.vtkConeSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConeSource = (vtkConeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConeSource.Register(null);
				}
			}
			return vtkConeSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetAngle_23(HandleRef pThis, double angle);

		public void SetAngle(double angle)
		{
			vtkConeSource.vtkConeSource_SetAngle_23(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetCapping_24(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkConeSource.vtkConeSource_SetCapping_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetCenter_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkConeSource.vtkConeSource_SetCenter_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetCenter_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkConeSource.vtkConeSource_SetCenter_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetDirection_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDirection(double _arg1, double _arg2, double _arg3)
		{
			vtkConeSource.vtkConeSource_SetDirection_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetDirection_28(HandleRef pThis, IntPtr _arg);

		public virtual void SetDirection(IntPtr _arg)
		{
			vtkConeSource.vtkConeSource_SetDirection_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetHeight_29(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkConeSource.vtkConeSource_SetHeight_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetRadius_30(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkConeSource.vtkConeSource_SetRadius_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConeSource_SetResolution_31(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkConeSource.vtkConeSource_SetResolution_31(base.GetCppThis(), _arg);
		}
	}
}
