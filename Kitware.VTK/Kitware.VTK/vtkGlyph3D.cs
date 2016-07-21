using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlyph3D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3D";

		public new static readonly string MRClassNameKey;

		static vtkGlyph3D()
		{
			vtkGlyph3D.MRClassNameKey = "class vtkGlyph3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3D"));
		}

		public vtkGlyph3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph3D New()
		{
			vtkGlyph3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlyph3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlyph3D.vtkGlyph3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_ClampingOff_01(HandleRef pThis);

		public virtual void ClampingOff()
		{
			vtkGlyph3D.vtkGlyph3D_ClampingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_ClampingOn_02(HandleRef pThis);

		public virtual void ClampingOn()
		{
			vtkGlyph3D.vtkGlyph3D_ClampingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_FillCellDataOff_03(HandleRef pThis);

		public virtual void FillCellDataOff()
		{
			vtkGlyph3D.vtkGlyph3D_FillCellDataOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_FillCellDataOn_04(HandleRef pThis);

		public virtual void FillCellDataOn()
		{
			vtkGlyph3D.vtkGlyph3D_FillCellDataOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_GeneratePointIdsOff_05(HandleRef pThis);

		public virtual void GeneratePointIdsOff()
		{
			vtkGlyph3D.vtkGlyph3D_GeneratePointIdsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_GeneratePointIdsOn_06(HandleRef pThis);

		public virtual void GeneratePointIdsOn()
		{
			vtkGlyph3D.vtkGlyph3D_GeneratePointIdsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetClamping_07(HandleRef pThis);

		public virtual int GetClamping()
		{
			return vtkGlyph3D.vtkGlyph3D_GetClamping_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetColorMode_08(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetColorMode_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetColorModeAsString_09(HandleRef pThis);

		public string GetColorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetColorModeAsString_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetFillCellData_10(HandleRef pThis);

		public virtual int GetFillCellData()
		{
			return vtkGlyph3D.vtkGlyph3D_GetFillCellData_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetGeneratePointIds_11(HandleRef pThis);

		public virtual int GetGeneratePointIds()
		{
			return vtkGlyph3D.vtkGlyph3D_GetGeneratePointIds_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetIndexMode_12(HandleRef pThis);

		public virtual int GetIndexMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetIndexMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetIndexModeAsString_13(HandleRef pThis);

		public string GetIndexModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetIndexModeAsString_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkGlyph3D_GetMTime_14(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGlyph3D.vtkGlyph3D_GetMTime_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetOrient_15(HandleRef pThis);

		public virtual int GetOrient()
		{
			return vtkGlyph3D.vtkGlyph3D_GetOrient_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetPointIdsName_16(HandleRef pThis);

		public virtual string GetPointIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetPointIdsName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetRange_17(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetRange_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_GetRange_18(HandleRef pThis, IntPtr data);

		public virtual void GetRange(IntPtr data)
		{
			vtkGlyph3D.vtkGlyph3D_GetRange_18(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGlyph3D_GetScaleFactor_19(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaleFactor_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetScaleMode_20(HandleRef pThis);

		public virtual int GetScaleMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaleMode_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetScaleModeAsString_21(HandleRef pThis);

		public string GetScaleModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetScaleModeAsString_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetScaling_22(HandleRef pThis);

		public virtual int GetScaling()
		{
			return vtkGlyph3D.vtkGlyph3D_GetScaling_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetSource_23(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource(int id)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetSource_23(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetSourceTransform_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetSourceTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_GetSourceTransform_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_GetVectorMode_25(HandleRef pThis);

		public virtual int GetVectorMode()
		{
			return vtkGlyph3D.vtkGlyph3D_GetVectorMode_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_GetVectorModeAsString_26(HandleRef pThis);

		public string GetVectorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGlyph3D.vtkGlyph3D_GetVectorModeAsString_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_IsPointVisible_28(HandleRef pThis, HandleRef arg0, long arg1);

		public virtual int IsPointVisible(vtkDataSet arg0, long arg1)
		{
			return vtkGlyph3D.vtkGlyph3D_IsPointVisible_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph3D_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlyph3D.vtkGlyph3D_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlyph3D NewInstance()
		{
			vtkGlyph3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_OrientOff_32(HandleRef pThis);

		public virtual void OrientOff()
		{
			vtkGlyph3D.vtkGlyph3D_OrientOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_OrientOn_33(HandleRef pThis);

		public virtual void OrientOn()
		{
			vtkGlyph3D.vtkGlyph3D_OrientOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph3D_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph3D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph3D vtkGlyph3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph3D.vtkGlyph3D_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph3D = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph3D.Register(null);
				}
			}
			return vtkGlyph3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_ScalingOff_35(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkGlyph3D.vtkGlyph3D_ScalingOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_ScalingOn_36(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkGlyph3D.vtkGlyph3D_ScalingOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetClamping_37(HandleRef pThis, int _arg);

		public virtual void SetClamping(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetClamping_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetColorMode_38(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetColorMode_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetColorModeToColorByScalar_39(HandleRef pThis);

		public void SetColorModeToColorByScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByScalar_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetColorModeToColorByScale_40(HandleRef pThis);

		public void SetColorModeToColorByScale()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByScale_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetColorModeToColorByVector_41(HandleRef pThis);

		public void SetColorModeToColorByVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetColorModeToColorByVector_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetFillCellData_42(HandleRef pThis, int _arg);

		public virtual void SetFillCellData(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetFillCellData_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetGeneratePointIds_43(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointIds(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetGeneratePointIds_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetIndexMode_44(HandleRef pThis, int _arg);

		public virtual void SetIndexMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexMode_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetIndexModeToOff_45(HandleRef pThis);

		public void SetIndexModeToOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToOff_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetIndexModeToScalar_46(HandleRef pThis);

		public void SetIndexModeToScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToScalar_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetIndexModeToVector_47(HandleRef pThis);

		public void SetIndexModeToVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetIndexModeToVector_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetOrient_48(HandleRef pThis, int _arg);

		public virtual void SetOrient(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetOrient_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetPointIdsName_49(HandleRef pThis, string _arg);

		public virtual void SetPointIdsName(string _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetPointIdsName_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetRange_50(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGlyph3D.vtkGlyph3D_SetRange_50(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetRange_51(HandleRef pThis, IntPtr _arg);

		public void SetRange(IntPtr _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetRange_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleFactor_52(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleFactor_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleMode_53(HandleRef pThis, int _arg);

		public virtual void SetScaleMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleMode_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleModeToDataScalingOff_54(HandleRef pThis);

		public void SetScaleModeToDataScalingOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToDataScalingOff_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByScalar_55(HandleRef pThis);

		public void SetScaleModeToScaleByScalar()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByScalar_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByVector_56(HandleRef pThis);

		public void SetScaleModeToScaleByVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByVector_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaleModeToScaleByVectorComponents_57(HandleRef pThis);

		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGlyph3D.vtkGlyph3D_SetScaleModeToScaleByVectorComponents_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetScaling_58(HandleRef pThis, int _arg);

		public virtual void SetScaling(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetScaling_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetSource_59(HandleRef pThis, HandleRef pd);

		public void SetSource(vtkPolyData pd)
		{
			vtkGlyph3D.vtkGlyph3D_SetSource_59(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetSource_60(HandleRef pThis, int id, HandleRef pd);

		public void SetSource(int id, vtkPolyData pd)
		{
			vtkGlyph3D.vtkGlyph3D_SetSource_60(base.GetCppThis(), id, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetSourceConnection_61(HandleRef pThis, int id, HandleRef algOutput);

		public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceConnection_61(base.GetCppThis(), id, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetSourceConnection_62(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceConnection_62(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetSourceTransform_63(HandleRef pThis, HandleRef arg0);

		public void SetSourceTransform(vtkTransform arg0)
		{
			vtkGlyph3D.vtkGlyph3D_SetSourceTransform_63(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetVectorMode_64(HandleRef pThis, int _arg);

		public virtual void SetVectorMode(int _arg)
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorMode_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetVectorModeToUseNormal_65(HandleRef pThis);

		public void SetVectorModeToUseNormal()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToUseNormal_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetVectorModeToUseVector_66(HandleRef pThis);

		public void SetVectorModeToUseVector()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToUseVector_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGlyph3D_SetVectorModeToVectorRotationOff_67(HandleRef pThis);

		public void SetVectorModeToVectorRotationOff()
		{
			vtkGlyph3D.vtkGlyph3D_SetVectorModeToVectorRotationOff_67(base.GetCppThis());
		}
	}
}
