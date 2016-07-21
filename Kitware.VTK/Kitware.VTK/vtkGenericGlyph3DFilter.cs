using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericGlyph3DFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGlyph3DFilter";

		public new static readonly string MRClassNameKey;

		static vtkGenericGlyph3DFilter()
		{
			vtkGenericGlyph3DFilter.MRClassNameKey = "class vtkGenericGlyph3DFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericGlyph3DFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGlyph3DFilter"));
		}

		public vtkGenericGlyph3DFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericGlyph3DFilter New()
		{
			vtkGenericGlyph3DFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericGlyph3DFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_ClampingOff_01(HandleRef pThis);

		public virtual void ClampingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ClampingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_ClampingOn_02(HandleRef pThis);

		public virtual void ClampingOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ClampingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(HandleRef pThis);

		public virtual void GeneratePointIdsOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(HandleRef pThis);

		public virtual void GeneratePointIdsOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetClamping_05(HandleRef pThis);

		public virtual int GetClamping()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetClamping_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetColorMode_06(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetColorMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetColorModeAsString_07(HandleRef pThis);

		public string GetColorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetColorModeAsString_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetGeneratePointIds_08(HandleRef pThis);

		public virtual int GetGeneratePointIds()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetGeneratePointIds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetIndexMode_09(HandleRef pThis);

		public virtual int GetIndexMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetIndexMode_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetIndexModeAsString_10(HandleRef pThis);

		public string GetIndexModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetIndexModeAsString_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(HandleRef pThis);

		public virtual string GetInputNormalsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(HandleRef pThis);

		public virtual string GetInputScalarsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(HandleRef pThis);

		public virtual string GetInputVectorsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetOrient_14(HandleRef pThis);

		public virtual int GetOrient()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetOrient_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetPointIdsName_15(HandleRef pThis);

		public virtual string GetPointIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetPointIdsName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetRange_16(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_GetRange_17(HandleRef pThis, IntPtr data);

		public virtual void GetRange(IntPtr data)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetRange_17(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericGlyph3DFilter_GetScaleFactor_18(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleFactor_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetScaleMode_19(HandleRef pThis);

		public virtual int GetScaleMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleMode_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetScaleModeAsString_20(HandleRef pThis);

		public string GetScaleModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaleModeAsString_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetScaling_21(HandleRef pThis);

		public virtual int GetScaling()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetScaling_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetSource_22(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource(int id)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetSource_22(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_GetVectorMode_23(HandleRef pThis);

		public virtual int GetVectorMode()
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetVectorMode_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_GetVectorModeAsString_24(HandleRef pThis);

		public string GetVectorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_GetVectorModeAsString_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGlyph3DFilter_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericGlyph3DFilter NewInstance()
		{
			vtkGenericGlyph3DFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_OrientOff_29(HandleRef pThis);

		public virtual void OrientOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_OrientOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_OrientOn_30(HandleRef pThis);

		public virtual void OrientOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_OrientOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGlyph3DFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericGlyph3DFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericGlyph3DFilter vtkGenericGlyph3DFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericGlyph3DFilter = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericGlyph3DFilter.Register(null);
				}
			}
			return vtkGenericGlyph3DFilter;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_ScalingOff_32(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ScalingOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_ScalingOn_33(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_ScalingOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputNormals_34(HandleRef pThis, string fieldName);

		public void SelectInputNormals(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputNormals_34(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputScalars_35(HandleRef pThis, string fieldName);

		public void SelectInputScalars(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputScalars_35(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SelectInputVectors_36(HandleRef pThis, string fieldName);

		public void SelectInputVectors(string fieldName)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SelectInputVectors_36(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetClamping_37(HandleRef pThis, int _arg);

		public virtual void SetClamping(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetClamping_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetColorMode_38(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorMode_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_39(HandleRef pThis);

		public void SetColorModeToColorByScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScale_40(HandleRef pThis);

		public void SetColorModeToColorByScale()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByScale_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByVector_41(HandleRef pThis);

		public void SetColorModeToColorByVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetColorModeToColorByVector_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetGeneratePointIds_42(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointIds(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetGeneratePointIds_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexMode_43(HandleRef pThis, int _arg);

		public virtual void SetIndexMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexMode_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToOff_44(HandleRef pThis);

		public void SetIndexModeToOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToScalar_45(HandleRef pThis);

		public void SetIndexModeToScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToScalar_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToVector_46(HandleRef pThis);

		public void SetIndexModeToVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetIndexModeToVector_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetOrient_47(HandleRef pThis, int _arg);

		public virtual void SetOrient(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetOrient_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetPointIdsName_48(HandleRef pThis, string _arg);

		public virtual void SetPointIdsName(string _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetPointIdsName_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetRange_49(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetRange_49(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetRange_50(HandleRef pThis, IntPtr _arg);

		public void SetRange(IntPtr _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetRange_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleFactor_51(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleFactor_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleMode_52(HandleRef pThis, int _arg);

		public virtual void SetScaleMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleMode_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_53(HandleRef pThis);

		public void SetScaleModeToDataScalingOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_54(HandleRef pThis);

		public void SetScaleModeToScaleByScalar()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_55(HandleRef pThis);

		public void SetScaleModeToScaleByVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_56(HandleRef pThis);

		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetScaling_57(HandleRef pThis, int _arg);

		public virtual void SetScaling(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetScaling_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetSource_58(HandleRef pThis, HandleRef pd);

		public void SetSource(vtkPolyData pd)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetSource_58(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetSource_59(HandleRef pThis, int id, HandleRef pd);

		public void SetSource(int id, vtkPolyData pd)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetSource_59(base.GetCppThis(), id, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorMode_60(HandleRef pThis, int _arg);

		public virtual void SetVectorMode(int _arg)
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorMode_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_61(HandleRef pThis);

		public void SetVectorModeToUseNormal()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseVector_62(HandleRef pThis);

		public void SetVectorModeToUseVector()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToUseVector_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_63(HandleRef pThis);

		public void SetVectorModeToVectorRotationOff()
		{
			vtkGenericGlyph3DFilter.vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_63(base.GetCppThis());
		}
	}
}
