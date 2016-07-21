using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlyph3DMapper : vtkMapper
	{
		public enum ArrayIndexes
		{
			MASK = 2,
			ORIENTATION,
			SCALE = 0,
			SOURCE_INDEX
		}

		public enum OrientationModes
		{
			DIRECTION,
			ROTATION
		}

		public enum ScaleModes
		{
			NO_DATA_SCALING,
			SCALE_BY_COMPONENTS = 2,
			SCALE_BY_MAGNITUDE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3DMapper";

		public new static readonly string MRClassNameKey;

		static vtkGlyph3DMapper()
		{
			vtkGlyph3DMapper.MRClassNameKey = "class vtkGlyph3DMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph3DMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3DMapper"));
		}

		public vtkGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph3DMapper New()
		{
			vtkGlyph3DMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlyph3DMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlyph3DMapper.vtkGlyph3DMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_ClampingOff_01(HandleRef pThis);

		public virtual void ClampingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ClampingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_ClampingOn_02(HandleRef pThis);

		public virtual void ClampingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ClampingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_GetBounds_04(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_GetBounds_04(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetClamping_05(HandleRef pThis);

		public virtual bool GetClamping()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetClamping_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetMasking_06(HandleRef pThis);

		public virtual bool GetMasking()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetMasking_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetNestedDisplayLists_07(HandleRef pThis);

		public virtual bool GetNestedDisplayLists()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetNestedDisplayLists_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetOrient_08(HandleRef pThis);

		public virtual bool GetOrient()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrient_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_GetOrientationMode_09(HandleRef pThis);

		public virtual int GetOrientationMode()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationMode_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_GetOrientationModeAsString_10(HandleRef pThis);

		public string GetOrientationModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeAsString_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_GetOrientationModeMaxValue_11(HandleRef pThis);

		public virtual int GetOrientationModeMaxValue()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_GetOrientationModeMinValue_12(HandleRef pThis);

		public virtual int GetOrientationModeMinValue()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_GetRange_13(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetRange_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_GetRange_14(HandleRef pThis, IntPtr data);

		public virtual void GetRange(IntPtr data)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_GetRange_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkGlyph3DMapper_GetScaleFactor_15(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleFactor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_GetScaleMode_16(HandleRef pThis);

		public virtual int GetScaleMode()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleMode_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_GetScaleModeAsString_17(HandleRef pThis);

		public string GetScaleModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleModeAsString_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetScaling_18(HandleRef pThis);

		public virtual bool GetScaling()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaling_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGlyph3DMapper_GetSelectionColorId_19(HandleRef pThis);

		public virtual uint GetSelectionColorId()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSelectionColorId_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_GetSource_20(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetSource_20(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetSourceIndexing_21(HandleRef pThis);

		public virtual bool GetSourceIndexing()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSourceIndexing_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGlyph3DMapper_GetSupportsSelection_22(HandleRef pThis);

		public override bool GetSupportsSelection()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSupportsSelection_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGlyph3DMapper_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_MaskingOff_25(HandleRef pThis);

		public virtual void MaskingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_MaskingOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_MaskingOn_26(HandleRef pThis);

		public virtual void MaskingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_MaskingOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_NestedDisplayListsOff_27(HandleRef pThis);

		public virtual void NestedDisplayListsOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_NestedDisplayListsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_NestedDisplayListsOn_28(HandleRef pThis);

		public virtual void NestedDisplayListsOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_NestedDisplayListsOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlyph3DMapper NewInstance()
		{
			vtkGlyph3DMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_OrientOff_31(HandleRef pThis);

		public virtual void OrientOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_OrientOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_OrientOn_32(HandleRef pThis);

		public virtual void OrientOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_OrientOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_Render_33(HandleRef pThis, HandleRef ren, HandleRef act);

		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_Render_33(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3DMapper_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph3DMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph3DMapper vtkGlyph3DMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph3DMapper = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph3DMapper.Register(null);
				}
			}
			return vtkGlyph3DMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_ScalingOff_35(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ScalingOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_ScalingOn_36(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ScalingOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetClamping_37(HandleRef pThis, byte _arg);

		public virtual void SetClamping(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetClamping_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetMaskArray_38(HandleRef pThis, string maskarrayname);

		public void SetMaskArray(string maskarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMaskArray_38(base.GetCppThis(), maskarrayname);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetMaskArray_39(HandleRef pThis, int fieldAttributeType);

		public void SetMaskArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMaskArray_39(base.GetCppThis(), fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetMasking_40(HandleRef pThis, byte _arg);

		public virtual void SetMasking(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMasking_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetNestedDisplayLists_41(HandleRef pThis, byte _arg);

		public virtual void SetNestedDisplayLists(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetNestedDisplayLists_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrient_42(HandleRef pThis, byte _arg);

		public virtual void SetOrient(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrient_42(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrientationArray_43(HandleRef pThis, string orientationarrayname);

		public void SetOrientationArray(string orientationarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationArray_43(base.GetCppThis(), orientationarrayname);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrientationArray_44(HandleRef pThis, int fieldAttributeType);

		public void SetOrientationArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationArray_44(base.GetCppThis(), fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrientationMode_45(HandleRef pThis, int _arg);

		public virtual void SetOrientationMode(int _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationMode_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrientationModeToDirection_46(HandleRef pThis);

		public void SetOrientationModeToDirection()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationModeToDirection_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetOrientationModeToRotation_47(HandleRef pThis);

		public void SetOrientationModeToRotation()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationModeToRotation_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetRange_48(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetRange_48(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetRange_49(HandleRef pThis, IntPtr _arg);

		public void SetRange(IntPtr _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetRange_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleArray_50(HandleRef pThis, string scalarsarrayname);

		public void SetScaleArray(string scalarsarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleArray_50(base.GetCppThis(), scalarsarrayname);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleArray_51(HandleRef pThis, int fieldAttributeType);

		public void SetScaleArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleArray_51(base.GetCppThis(), fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleFactor_52(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleFactor_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleMode_53(HandleRef pThis, int _arg);

		public virtual void SetScaleMode(int _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleMode_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToNoDataScaling_54(HandleRef pThis);

		public void SetScaleModeToNoDataScaling()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToNoDataScaling_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_55(HandleRef pThis);

		public void SetScaleModeToScaleByMagnitude()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_56(HandleRef pThis);

		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetScaling_57(HandleRef pThis, byte _arg);

		public virtual void SetScaling(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaling_57(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSelectMode_58(HandleRef pThis, int _arg);

		public virtual void SetSelectMode(int _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSelectMode_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSelectionColorId_59(HandleRef pThis, uint _arg);

		public virtual void SetSelectionColorId(uint _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSelectionColorId_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSource_60(HandleRef pThis, int idx, HandleRef pd);

		public void SetSource(int idx, vtkPolyData pd)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSource_60(base.GetCppThis(), idx, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSource_61(HandleRef pThis, HandleRef pd);

		public void SetSource(vtkPolyData pd)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSource_61(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSourceConnection_62(HandleRef pThis, int idx, HandleRef algOutput);

		public void SetSourceConnection(int idx, vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceConnection_62(base.GetCppThis(), idx, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSourceConnection_63(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceConnection_63(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_64(HandleRef pThis, string arrayname);

		public void SetSourceIndexArray(string arrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexArray_64(base.GetCppThis(), arrayname);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_65(HandleRef pThis, int fieldAttributeType);

		public void SetSourceIndexArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexArray_65(base.GetCppThis(), fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexing_66(HandleRef pThis, byte _arg);

		public virtual void SetSourceIndexing(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexing_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SourceIndexingOff_67(HandleRef pThis);

		public virtual void SourceIndexingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SourceIndexingOff_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGlyph3DMapper_SourceIndexingOn_68(HandleRef pThis);

		public virtual void SourceIndexingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SourceIndexingOn_68(base.GetCppThis());
		}
	}
}
