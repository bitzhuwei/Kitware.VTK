using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArcPlotter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcPlotter";

		public new static readonly string MRClassNameKey;

		static vtkArcPlotter()
		{
			vtkArcPlotter.MRClassNameKey = "class vtkArcPlotter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcPlotter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcPlotter"));
		}

		public vtkArcPlotter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkArcPlotter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcPlotter New()
		{
			vtkArcPlotter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArcPlotter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArcPlotter.vtkArcPlotter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkArcPlotter_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_GetCamera_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkArcPlotter_GetDefaultNormal_02(HandleRef pThis);

		public virtual float[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_GetDefaultNormal_02(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_GetDefaultNormal_03(HandleRef pThis, IntPtr data);

		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkArcPlotter.vtkArcPlotter_GetDefaultNormal_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetFieldDataArray_04(HandleRef pThis);

		public virtual int GetFieldDataArray()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArray_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetFieldDataArrayMaxValue_05(HandleRef pThis);

		public virtual int GetFieldDataArrayMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArrayMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetFieldDataArrayMinValue_06(HandleRef pThis);

		public virtual int GetFieldDataArrayMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArrayMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetHeight_07(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeight_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetHeightMaxValue_08(HandleRef pThis);

		public virtual double GetHeightMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeightMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetHeightMinValue_09(HandleRef pThis);

		public virtual double GetHeightMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeightMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkArcPlotter_GetMTime_10(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkArcPlotter.vtkArcPlotter_GetMTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetOffset_11(HandleRef pThis);

		public virtual double GetOffset()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffset_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetOffsetMaxValue_12(HandleRef pThis);

		public virtual double GetOffsetMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffsetMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetOffsetMinValue_13(HandleRef pThis);

		public virtual double GetOffsetMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffsetMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetPlotComponent_14(HandleRef pThis);

		public virtual int GetPlotComponent()
		{
			return vtkArcPlotter.vtkArcPlotter_GetPlotComponent_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetPlotMode_15(HandleRef pThis);

		public virtual int GetPlotMode()
		{
			return vtkArcPlotter.vtkArcPlotter_GetPlotMode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetRadius_16(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadius_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetRadiusMaxValue_17(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadiusMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkArcPlotter_GetRadiusMinValue_18(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadiusMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_GetUseDefaultNormal_19(HandleRef pThis);

		public virtual int GetUseDefaultNormal()
		{
			return vtkArcPlotter.vtkArcPlotter_GetUseDefaultNormal_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkArcPlotter_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkArcPlotter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArcPlotter NewInstance()
		{
			vtkArcPlotter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkArcPlotter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcPlotter SafeDownCast(vtkObjectBase o)
		{
			vtkArcPlotter vtkArcPlotter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcPlotter = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcPlotter.Register(null);
				}
			}
			return vtkArcPlotter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetCamera_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkArcPlotter.vtkArcPlotter_SetCamera_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetDefaultNormal_26(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		public virtual void SetDefaultNormal(float _arg1, float _arg2, float _arg3)
		{
			vtkArcPlotter.vtkArcPlotter_SetDefaultNormal_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetDefaultNormal_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetDefaultNormal_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetFieldDataArray_28(HandleRef pThis, int _arg);

		public virtual void SetFieldDataArray(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetFieldDataArray_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetHeight_29(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetHeight_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetOffset_30(HandleRef pThis, double _arg);

		public virtual void SetOffset(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetOffset_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotComponent_31(HandleRef pThis, int _arg);

		public virtual void SetPlotComponent(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotComponent_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotMode_32(HandleRef pThis, int _arg);

		public virtual void SetPlotMode(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotMode_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotFieldData_33(HandleRef pThis);

		public void SetPlotModeToPlotFieldData()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotFieldData_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotNormals_34(HandleRef pThis);

		public void SetPlotModeToPlotNormals()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotNormals_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotScalars_35(HandleRef pThis);

		public void SetPlotModeToPlotScalars()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotScalars_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotTCoords_36(HandleRef pThis);

		public void SetPlotModeToPlotTCoords()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotTCoords_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotTensors_37(HandleRef pThis);

		public void SetPlotModeToPlotTensors()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotTensors_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotVectors_38(HandleRef pThis);

		public void SetPlotModeToPlotVectors()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotVectors_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetRadius_39(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetRadius_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_SetUseDefaultNormal_40(HandleRef pThis, int _arg);

		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetUseDefaultNormal_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_UseDefaultNormalOff_41(HandleRef pThis);

		public virtual void UseDefaultNormalOff()
		{
			vtkArcPlotter.vtkArcPlotter_UseDefaultNormalOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkArcPlotter_UseDefaultNormalOn_42(HandleRef pThis);

		public virtual void UseDefaultNormalOn()
		{
			vtkArcPlotter.vtkArcPlotter_UseDefaultNormalOn_42(base.GetCppThis());
		}
	}
}
