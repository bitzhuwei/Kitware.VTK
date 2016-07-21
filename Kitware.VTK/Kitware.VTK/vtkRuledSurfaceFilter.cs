using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRuledSurfaceFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRuledSurfaceFilter";

		public new static readonly string MRClassNameKey;

		static vtkRuledSurfaceFilter()
		{
			vtkRuledSurfaceFilter.MRClassNameKey = "class vtkRuledSurfaceFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRuledSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRuledSurfaceFilter"));
		}

		public vtkRuledSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRuledSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRuledSurfaceFilter New()
		{
			vtkRuledSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRuledSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_CloseSurfaceOff_01(HandleRef pThis);

		public virtual void CloseSurfaceOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_CloseSurfaceOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_CloseSurfaceOn_02(HandleRef pThis);

		public virtual void CloseSurfaceOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_CloseSurfaceOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetCloseSurface_03(HandleRef pThis);

		public virtual int GetCloseSurface()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetCloseSurface_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactor_04(HandleRef pThis);

		public virtual double GetDistanceFactor()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactor_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactorMaxValue_05(HandleRef pThis);

		public virtual double GetDistanceFactorMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactorMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRuledSurfaceFilter_GetDistanceFactorMinValue_06(HandleRef pThis);

		public virtual double GetDistanceFactorMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetDistanceFactorMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOffset_07(HandleRef pThis);

		public virtual int GetOffset()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffset_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOffsetMaxValue_08(HandleRef pThis);

		public virtual int GetOffsetMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffsetMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOffsetMinValue_09(HandleRef pThis);

		public virtual int GetOffsetMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOffsetMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatio_10(HandleRef pThis);

		public virtual int GetOnRatio()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatio_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatioMaxValue_11(HandleRef pThis);

		public virtual int GetOnRatioMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatioMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOnRatioMinValue_12(HandleRef pThis);

		public virtual int GetOnRatioMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOnRatioMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetOrientLoops_13(HandleRef pThis);

		public virtual int GetOrientLoops()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetOrientLoops_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetPassLines_14(HandleRef pThis);

		public virtual int GetPassLines()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetPassLines_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRuledSurfaceFilter_GetResolution_15(HandleRef pThis);

		public virtual int[] GetResolution()
		{
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetResolution_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_GetResolution_16(HandleRef pThis, IntPtr data);

		public virtual void GetResolution(IntPtr data)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetResolution_16(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetRuledMode_17(HandleRef pThis);

		public virtual int GetRuledMode()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledMode_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRuledSurfaceFilter_GetRuledModeAsString_18(HandleRef pThis);

		public string GetRuledModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeAsString_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetRuledModeMaxValue_19(HandleRef pThis);

		public virtual int GetRuledModeMaxValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_GetRuledModeMinValue_20(HandleRef pThis);

		public virtual int GetRuledModeMinValue()
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_GetRuledModeMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRuledSurfaceFilter_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRuledSurfaceFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRuledSurfaceFilter NewInstance()
		{
			vtkRuledSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_OrientLoopsOff_25(HandleRef pThis);

		public virtual void OrientLoopsOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_OrientLoopsOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_OrientLoopsOn_26(HandleRef pThis);

		public virtual void OrientLoopsOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_OrientLoopsOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_PassLinesOff_27(HandleRef pThis);

		public virtual void PassLinesOff()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_PassLinesOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_PassLinesOn_28(HandleRef pThis);

		public virtual void PassLinesOn()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_PassLinesOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRuledSurfaceFilter_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRuledSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRuledSurfaceFilter vtkRuledSurfaceFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRuledSurfaceFilter = (vtkRuledSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRuledSurfaceFilter.Register(null);
				}
			}
			return vtkRuledSurfaceFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetCloseSurface_30(HandleRef pThis, int _arg);

		public virtual void SetCloseSurface(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetCloseSurface_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetDistanceFactor_31(HandleRef pThis, double _arg);

		public virtual void SetDistanceFactor(double _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetDistanceFactor_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetOffset_32(HandleRef pThis, int _arg);

		public virtual void SetOffset(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOffset_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetOnRatio_33(HandleRef pThis, int _arg);

		public virtual void SetOnRatio(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOnRatio_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetOrientLoops_34(HandleRef pThis, int _arg);

		public virtual void SetOrientLoops(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetOrientLoops_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetPassLines_35(HandleRef pThis, int _arg);

		public virtual void SetPassLines(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetPassLines_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetResolution_36(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetResolution(int _arg1, int _arg2)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetResolution_36(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetResolution_37(HandleRef pThis, IntPtr _arg);

		public void SetResolution(IntPtr _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetResolution_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetRuledMode_38(HandleRef pThis, int _arg);

		public virtual void SetRuledMode(int _arg)
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledMode_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetRuledModeToPointWalk_39(HandleRef pThis);

		public void SetRuledModeToPointWalk()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledModeToPointWalk_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRuledSurfaceFilter_SetRuledModeToResample_40(HandleRef pThis);

		public void SetRuledModeToResample()
		{
			vtkRuledSurfaceFilter.vtkRuledSurfaceFilter_SetRuledModeToResample_40(base.GetCppThis());
		}
	}
}
