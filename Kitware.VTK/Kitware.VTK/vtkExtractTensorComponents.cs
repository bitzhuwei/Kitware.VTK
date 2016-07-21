using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractTensorComponents : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTensorComponents";

		public new static readonly string MRClassNameKey;

		static vtkExtractTensorComponents()
		{
			vtkExtractTensorComponents.MRClassNameKey = "class vtkExtractTensorComponents";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractTensorComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTensorComponents"));
		}

		public vtkExtractTensorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractTensorComponents New()
		{
			vtkExtractTensorComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractTensorComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractTensorComponents.vtkExtractTensorComponents_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractNormalsOff_01(HandleRef pThis);

		public virtual void ExtractNormalsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractNormalsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractNormalsOn_02(HandleRef pThis);

		public virtual void ExtractNormalsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractNormalsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractScalarsOff_03(HandleRef pThis);

		public virtual void ExtractScalarsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractScalarsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractScalarsOn_04(HandleRef pThis);

		public virtual void ExtractScalarsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractScalarsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractTCoordsOff_05(HandleRef pThis);

		public virtual void ExtractTCoordsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractTCoordsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractTCoordsOn_06(HandleRef pThis);

		public virtual void ExtractTCoordsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractTCoordsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractVectorsOff_07(HandleRef pThis);

		public virtual void ExtractVectorsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractVectorsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ExtractVectorsOn_08(HandleRef pThis);

		public virtual void ExtractVectorsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractVectorsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetExtractNormals_09(HandleRef pThis);

		public virtual int GetExtractNormals()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractNormals_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetExtractScalars_10(HandleRef pThis);

		public virtual int GetExtractScalars()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractScalars_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetExtractTCoords_11(HandleRef pThis);

		public virtual int GetExtractTCoords()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractTCoords_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetExtractVectors_12(HandleRef pThis);

		public virtual int GetExtractVectors()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractVectors_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_GetNormalComponents_13(HandleRef pThis);

		public virtual int[] GetNormalComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalComponents_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_GetNormalComponents_14(HandleRef pThis, IntPtr data);

		public virtual void GetNormalComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalComponents_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetNormalizeNormals_15(HandleRef pThis);

		public virtual int GetNormalizeNormals()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalizeNormals_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoords_16(HandleRef pThis);

		public virtual int GetNumberOfTCoords()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoords_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_17(HandleRef pThis);

		public virtual int GetNumberOfTCoordsMaxValue()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_18(HandleRef pThis);

		public virtual int GetNumberOfTCoordsMinValue()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetPassTensorsToOutput_19(HandleRef pThis);

		public virtual int GetPassTensorsToOutput()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetPassTensorsToOutput_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_GetScalarComponents_20(HandleRef pThis);

		public virtual int[] GetScalarComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarComponents_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_GetScalarComponents_21(HandleRef pThis, IntPtr data);

		public virtual void GetScalarComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarComponents_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_GetScalarMode_22(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarMode_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_GetTCoordComponents_23(HandleRef pThis);

		public virtual int[] GetTCoordComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetTCoordComponents_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_GetTCoordComponents_24(HandleRef pThis, IntPtr data);

		public virtual void GetTCoordComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetTCoordComponents_24(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_GetVectorComponents_25(HandleRef pThis);

		public virtual int[] GetVectorComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetVectorComponents_25(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_GetVectorComponents_26(HandleRef pThis, IntPtr data);

		public virtual void GetVectorComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetVectorComponents_26(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTensorComponents_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractTensorComponents NewInstance()
		{
			vtkExtractTensorComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_NormalizeNormalsOff_31(HandleRef pThis);

		public virtual void NormalizeNormalsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_NormalizeNormalsOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_NormalizeNormalsOn_32(HandleRef pThis);

		public virtual void NormalizeNormalsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_NormalizeNormalsOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOff_33(HandleRef pThis);

		public virtual void PassTensorsToOutputOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_PassTensorsToOutputOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOn_34(HandleRef pThis);

		public virtual void PassTensorsToOutputOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_PassTensorsToOutputOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTensorComponents_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractTensorComponents SafeDownCast(vtkObjectBase o)
		{
			vtkExtractTensorComponents vtkExtractTensorComponents = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractTensorComponents = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractTensorComponents.Register(null);
				}
			}
			return vtkExtractTensorComponents;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ScalarIsComponent_36(HandleRef pThis);

		public void ScalarIsComponent()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsComponent_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ScalarIsDeterminant_37(HandleRef pThis);

		public void ScalarIsDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsDeterminant_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_ScalarIsEffectiveStress_38(HandleRef pThis);

		public void ScalarIsEffectiveStress()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsEffectiveStress_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetExtractNormals_39(HandleRef pThis, int _arg);

		public virtual void SetExtractNormals(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractNormals_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetExtractScalars_40(HandleRef pThis, int _arg);

		public virtual void SetExtractScalars(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractScalars_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetExtractTCoords_41(HandleRef pThis, int _arg);

		public virtual void SetExtractTCoords(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractTCoords_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetExtractVectors_42(HandleRef pThis, int _arg);

		public virtual void SetExtractVectors(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractVectors_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetNormalComponents_43(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetNormalComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalComponents_43(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetNormalComponents_44(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormalComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalComponents_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetNormalizeNormals_45(HandleRef pThis, int _arg);

		public virtual void SetNormalizeNormals(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalizeNormals_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetNumberOfTCoords_46(HandleRef pThis, int _arg);

		public virtual void SetNumberOfTCoords(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNumberOfTCoords_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetPassTensorsToOutput_47(HandleRef pThis, int _arg);

		public virtual void SetPassTensorsToOutput(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetPassTensorsToOutput_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarComponents_48(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetScalarComponents(int _arg1, int _arg2)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarComponents_48(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarComponents_49(HandleRef pThis, IntPtr _arg);

		public void SetScalarComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarComponents_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarMode_50(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarMode_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToComponent_51(HandleRef pThis);

		public void SetScalarModeToComponent()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToComponent_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToDeterminant_52(HandleRef pThis);

		public void SetScalarModeToDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToDeterminant_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToEffectiveStress_53(HandleRef pThis);

		public void SetScalarModeToEffectiveStress()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToEffectiveStress_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetTCoordComponents_54(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetTCoordComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetTCoordComponents_54(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetTCoordComponents_55(HandleRef pThis, IntPtr _arg);

		public virtual void SetTCoordComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetTCoordComponents_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetVectorComponents_56(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetVectorComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetVectorComponents_56(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractTensorComponents_SetVectorComponents_57(HandleRef pThis, IntPtr _arg);

		public virtual void SetVectorComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetVectorComponents_57(base.GetCppThis(), _arg);
		}
	}
}
