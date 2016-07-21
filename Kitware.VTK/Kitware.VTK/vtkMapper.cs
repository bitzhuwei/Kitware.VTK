using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkMapper : vtkAbstractMapper3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapper";

		public new static readonly string MRClassNameKey;

		static vtkMapper()
		{
			vtkMapper.MRClassNameKey = "class vtkMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapper"));
		}

		public vtkMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ColorByArrayComponent_01(HandleRef pThis, int arrayNum, int component);

		public void ColorByArrayComponent(int arrayNum, int component)
		{
			vtkMapper.vtkMapper_ColorByArrayComponent_01(base.GetCppThis(), arrayNum, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ColorByArrayComponent_02(HandleRef pThis, string arrayName, int component);

		public void ColorByArrayComponent(string arrayName, int component)
		{
			vtkMapper.vtkMapper_ColorByArrayComponent_02(base.GetCppThis(), arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_CreateDefaultLookupTable_03(HandleRef pThis);

		public virtual void CreateDefaultLookupTable()
		{
			vtkMapper.vtkMapper_CreateDefaultLookupTable_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetArrayAccessMode_04(HandleRef pThis);

		public int GetArrayAccessMode()
		{
			return vtkMapper.vtkMapper_GetArrayAccessMode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetArrayComponent_05(HandleRef pThis);

		public int GetArrayComponent()
		{
			return vtkMapper.vtkMapper_GetArrayComponent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetArrayId_06(HandleRef pThis);

		public int GetArrayId()
		{
			return vtkMapper.vtkMapper_GetArrayId_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetArrayName_07(HandleRef pThis);

		public string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetBounds_08(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMapper.vtkMapper_GetBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_GetBounds_09(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkMapper.vtkMapper_GetBounds_09(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetColorMode_10(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkMapper.vtkMapper_GetColorMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetColorModeAsString_11(HandleRef pThis);

		public string GetColorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetColorModeAsString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetForceCompileOnly_12(HandleRef pThis);

		public virtual int GetForceCompileOnly()
		{
			return vtkMapper.vtkMapper_GetForceCompileOnly_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetGlobalImmediateModeRendering_13();

		public static int GetGlobalImmediateModeRendering()
		{
			return vtkMapper.vtkMapper_GetGlobalImmediateModeRendering_13();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetImmediateModeRendering_14(HandleRef pThis);

		public virtual int GetImmediateModeRendering()
		{
			return vtkMapper.vtkMapper_GetImmediateModeRendering_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_GetInput_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetInputAsDataSet_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInputAsDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_GetInputAsDataSet_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetInterpolateScalarsBeforeMapping_17(HandleRef pThis);

		public virtual int GetInterpolateScalarsBeforeMapping()
		{
			return vtkMapper.vtkMapper_GetInterpolateScalarsBeforeMapping_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetLookupTable_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_GetLookupTable_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkMapper_GetMTime_19(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMapper.vtkMapper_GetMTime_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkMapper_GetRenderTime_20(HandleRef pThis);

		public virtual double GetRenderTime()
		{
			return vtkMapper.vtkMapper_GetRenderTime_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetResolveCoincidentTopology_21();

		public static int GetResolveCoincidentTopology()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopology_21();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_22();

		public static int GetResolveCoincidentTopologyPolygonOffsetFaces()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_22();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_23(ref double factor, ref double units);

		public static void GetResolveCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
		{
			vtkMapper.vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_23(ref factor, ref units);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkMapper_GetResolveCoincidentTopologyZShift_24();

		public static double GetResolveCoincidentTopologyZShift()
		{
			return vtkMapper.vtkMapper_GetResolveCoincidentTopologyZShift_24();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetScalarMaterialMode_25(HandleRef pThis);

		public virtual int GetScalarMaterialMode()
		{
			return vtkMapper.vtkMapper_GetScalarMaterialMode_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetScalarMaterialModeAsString_26(HandleRef pThis);

		public string GetScalarMaterialModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetScalarMaterialModeAsString_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetScalarMode_27(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkMapper.vtkMapper_GetScalarMode_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetScalarModeAsString_28(HandleRef pThis);

		public string GetScalarModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkMapper.vtkMapper_GetScalarModeAsString_28(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_GetScalarRange_29(HandleRef pThis);

		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkMapper.vtkMapper_GetScalarRange_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_GetScalarRange_30(HandleRef pThis, IntPtr data);

		public virtual void GetScalarRange(IntPtr data)
		{
			vtkMapper.vtkMapper_GetScalarRange_30(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetScalarVisibility_31(HandleRef pThis);

		public virtual int GetScalarVisibility()
		{
			return vtkMapper.vtkMapper_GetScalarVisibility_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetStatic_32(HandleRef pThis);

		public virtual int GetStatic()
		{
			return vtkMapper.vtkMapper_GetStatic_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkMapper_GetSupportsSelection_33(HandleRef pThis);

		public virtual bool GetSupportsSelection()
		{
			return vtkMapper.vtkMapper_GetSupportsSelection_33(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_GetUseLookupTableScalarRange_34(HandleRef pThis);

		public virtual int GetUseLookupTableScalarRange()
		{
			return vtkMapper.vtkMapper_GetUseLookupTableScalarRange_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_GlobalImmediateModeRenderingOff_35();

		public static void GlobalImmediateModeRenderingOff()
		{
			vtkMapper.vtkMapper_GlobalImmediateModeRenderingOff_35();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_GlobalImmediateModeRenderingOn_36();

		public static void GlobalImmediateModeRenderingOn()
		{
			vtkMapper.vtkMapper_GlobalImmediateModeRenderingOn_36();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ImmediateModeRenderingOff_37(HandleRef pThis);

		public virtual void ImmediateModeRenderingOff()
		{
			vtkMapper.vtkMapper_ImmediateModeRenderingOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ImmediateModeRenderingOn_38(HandleRef pThis);

		public virtual void ImmediateModeRenderingOn()
		{
			vtkMapper.vtkMapper_ImmediateModeRenderingOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOff_39(HandleRef pThis);

		public virtual void InterpolateScalarsBeforeMappingOff()
		{
			vtkMapper.vtkMapper_InterpolateScalarsBeforeMappingOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOn_40(HandleRef pThis);

		public virtual void InterpolateScalarsBeforeMappingOn()
		{
			vtkMapper.vtkMapper_InterpolateScalarsBeforeMappingOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_IsA_41(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMapper.vtkMapper_IsA_41(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkMapper_IsTypeOf_42(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMapper.vtkMapper_IsTypeOf_42(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_MapScalars_43(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray MapScalars(double alpha)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_MapScalars_43(base.GetCppThis(), alpha, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMapper NewInstance()
		{
			vtkMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_NewInstance_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ReleaseGraphicsResources_45(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkMapper.vtkMapper_ReleaseGraphicsResources_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_Render_46(HandleRef pThis, HandleRef ren, HandleRef a);

		public virtual void Render(vtkRenderer ren, vtkActor a)
		{
			vtkMapper.vtkMapper_Render_46(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMapper SafeDownCast(vtkObjectBase o)
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper.vtkMapper_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ScalarVisibilityOff_48(HandleRef pThis);

		public virtual void ScalarVisibilityOff()
		{
			vtkMapper.vtkMapper_ScalarVisibilityOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ScalarVisibilityOn_49(HandleRef pThis);

		public virtual void ScalarVisibilityOn()
		{
			vtkMapper.vtkMapper_ScalarVisibilityOn_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SelectColorArray_50(HandleRef pThis, int arrayNum);

		public void SelectColorArray(int arrayNum)
		{
			vtkMapper.vtkMapper_SelectColorArray_50(base.GetCppThis(), arrayNum);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SelectColorArray_51(HandleRef pThis, string arrayName);

		public void SelectColorArray(string arrayName)
		{
			vtkMapper.vtkMapper_SelectColorArray_51(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetColorMode_52(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkMapper.vtkMapper_SetColorMode_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetColorModeToDefault_53(HandleRef pThis);

		public void SetColorModeToDefault()
		{
			vtkMapper.vtkMapper_SetColorModeToDefault_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetColorModeToMapScalars_54(HandleRef pThis);

		public void SetColorModeToMapScalars()
		{
			vtkMapper.vtkMapper_SetColorModeToMapScalars_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetForceCompileOnly_55(HandleRef pThis, int value);

		public void SetForceCompileOnly(int value)
		{
			vtkMapper.vtkMapper_SetForceCompileOnly_55(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetGlobalImmediateModeRendering_56(int val);

		public static void SetGlobalImmediateModeRendering(int val)
		{
			vtkMapper.vtkMapper_SetGlobalImmediateModeRendering_56(val);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetImmediateModeRendering_57(HandleRef pThis, int _arg);

		public virtual void SetImmediateModeRendering(int _arg)
		{
			vtkMapper.vtkMapper_SetImmediateModeRendering_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetInterpolateScalarsBeforeMapping_58(HandleRef pThis, int _arg);

		public virtual void SetInterpolateScalarsBeforeMapping(int _arg)
		{
			vtkMapper.vtkMapper_SetInterpolateScalarsBeforeMapping_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetLookupTable_59(HandleRef pThis, HandleRef lut);

		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkMapper.vtkMapper_SetLookupTable_59(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetRenderTime_60(HandleRef pThis, double time);

		public void SetRenderTime(double time)
		{
			vtkMapper.vtkMapper_SetRenderTime_60(base.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopology_61(int val);

		public static void SetResolveCoincidentTopology(int val)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopology_61(val);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_62(int faces);

		public static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_62(faces);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_63(double factor, double units);

		public static void SetResolveCoincidentTopologyPolygonOffsetParameters(double factor, double units)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_63(factor, units);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToDefault_64();

		public static void SetResolveCoincidentTopologyToDefault()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToDefault_64();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToOff_65();

		public static void SetResolveCoincidentTopologyToOff()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToOff_65();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_66();

		public static void SetResolveCoincidentTopologyToPolygonOffset()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_66();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_67();

		public static void SetResolveCoincidentTopologyToShiftZBuffer()
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_67();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetResolveCoincidentTopologyZShift_68(double val);

		public static void SetResolveCoincidentTopologyZShift(double val)
		{
			vtkMapper.vtkMapper_SetResolveCoincidentTopologyZShift_68(val);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMaterialMode_69(HandleRef pThis, int _arg);

		public virtual void SetScalarMaterialMode(int _arg)
		{
			vtkMapper.vtkMapper_SetScalarMaterialMode_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMaterialModeToAmbient_70(HandleRef pThis);

		public void SetScalarMaterialModeToAmbient()
		{
			vtkMapper.vtkMapper_SetScalarMaterialModeToAmbient_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMaterialModeToAmbientAndDiffuse_71(HandleRef pThis);

		public void SetScalarMaterialModeToAmbientAndDiffuse()
		{
			vtkMapper.vtkMapper_SetScalarMaterialModeToAmbientAndDiffuse_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMaterialModeToDefault_72(HandleRef pThis);

		public void SetScalarMaterialModeToDefault()
		{
			vtkMapper.vtkMapper_SetScalarMaterialModeToDefault_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMaterialModeToDiffuse_73(HandleRef pThis);

		public void SetScalarMaterialModeToDiffuse()
		{
			vtkMapper.vtkMapper_SetScalarMaterialModeToDiffuse_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarMode_74(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkMapper.vtkMapper_SetScalarMode_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToDefault_75(HandleRef pThis);

		public void SetScalarModeToDefault()
		{
			vtkMapper.vtkMapper_SetScalarModeToDefault_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToUseCellData_76(HandleRef pThis);

		public void SetScalarModeToUseCellData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseCellData_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToUseCellFieldData_77(HandleRef pThis);

		public void SetScalarModeToUseCellFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseCellFieldData_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToUseFieldData_78(HandleRef pThis);

		public void SetScalarModeToUseFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUseFieldData_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToUsePointData_79(HandleRef pThis);

		public void SetScalarModeToUsePointData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUsePointData_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarModeToUsePointFieldData_80(HandleRef pThis);

		public void SetScalarModeToUsePointFieldData()
		{
			vtkMapper.vtkMapper_SetScalarModeToUsePointFieldData_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarRange_81(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkMapper.vtkMapper_SetScalarRange_81(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarRange_82(HandleRef pThis, IntPtr _arg);

		public void SetScalarRange(IntPtr _arg)
		{
			vtkMapper.vtkMapper_SetScalarRange_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetScalarVisibility_83(HandleRef pThis, int _arg);

		public virtual void SetScalarVisibility(int _arg)
		{
			vtkMapper.vtkMapper_SetScalarVisibility_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetStatic_84(HandleRef pThis, int _arg);

		public virtual void SetStatic(int _arg)
		{
			vtkMapper.vtkMapper_SetStatic_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_SetUseLookupTableScalarRange_85(HandleRef pThis, int _arg);

		public virtual void SetUseLookupTableScalarRange(int _arg)
		{
			vtkMapper.vtkMapper_SetUseLookupTableScalarRange_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_ShallowCopy_86(HandleRef pThis, HandleRef m);

		public new void ShallowCopy(vtkAbstractMapper m)
		{
			vtkMapper.vtkMapper_ShallowCopy_86(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_StaticOff_87(HandleRef pThis);

		public virtual void StaticOff()
		{
			vtkMapper.vtkMapper_StaticOff_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_StaticOn_88(HandleRef pThis);

		public virtual void StaticOn()
		{
			vtkMapper.vtkMapper_StaticOn_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_UseLookupTableScalarRangeOff_89(HandleRef pThis);

		public virtual void UseLookupTableScalarRangeOff()
		{
			vtkMapper.vtkMapper_UseLookupTableScalarRangeOff_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkMapper_UseLookupTableScalarRangeOn_90(HandleRef pThis);

		public virtual void UseLookupTableScalarRangeOn()
		{
			vtkMapper.vtkMapper_UseLookupTableScalarRangeOn_90(base.GetCppThis());
		}
	}
}
