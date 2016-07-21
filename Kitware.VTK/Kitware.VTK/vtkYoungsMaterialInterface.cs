using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkYoungsMaterialInterface : vtkMultiBlockDataSetAlgorithm
	{
		public enum MAX_CELL_POINTS_WrapperEnum
		{
			MAX_CELL_POINTS = 256
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkYoungsMaterialInterface";

		public new static readonly string MRClassNameKey;

		static vtkYoungsMaterialInterface()
		{
			vtkYoungsMaterialInterface.MRClassNameKey = "class vtkYoungsMaterialInterface";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkYoungsMaterialInterface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkYoungsMaterialInterface"));
		}

		public vtkYoungsMaterialInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkYoungsMaterialInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkYoungsMaterialInterface New()
		{
			vtkYoungsMaterialInterface result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkYoungsMaterialInterface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_AxisSymetricOff_01(HandleRef pThis);

		public virtual void AxisSymetricOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_AxisSymetricOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_AxisSymetricOn_02(HandleRef pThis);

		public virtual void AxisSymetricOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_AxisSymetricOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_FillMaterialOff_03(HandleRef pThis);

		public virtual void FillMaterialOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_FillMaterialOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_FillMaterialOn_04(HandleRef pThis);

		public virtual void FillMaterialOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_FillMaterialOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetAxisSymetric_05(HandleRef pThis);

		public virtual int GetAxisSymetric()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetAxisSymetric_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetFillMaterial_06(HandleRef pThis);

		public virtual int GetFillMaterial()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetFillMaterial_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetInverseNormal_07(HandleRef pThis);

		public virtual int GetInverseNormal()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetInverseNormal_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetNumberOfMaterials_08(HandleRef pThis);

		public virtual int GetNumberOfMaterials()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetNumberOfMaterials_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetOnionPeel_09(HandleRef pThis);

		public virtual int GetOnionPeel()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetOnionPeel_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetReverseMaterialOrder_10(HandleRef pThis);

		public virtual int GetReverseMaterialOrder()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetReverseMaterialOrder_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetTwoMaterialsOptimization_11(HandleRef pThis);

		public virtual int GetTwoMaterialsOptimization()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetTwoMaterialsOptimization_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_GetUseFractionAsDistance_12(HandleRef pThis);

		public virtual int GetUseFractionAsDistance()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetUseFractionAsDistance_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkYoungsMaterialInterface_GetVolumeFractionRange_13(HandleRef pThis);

		public virtual double[] GetVolumeFractionRange()
		{
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetVolumeFractionRange_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_GetVolumeFractionRange_14(HandleRef pThis, IntPtr data);

		public virtual void GetVolumeFractionRange(IntPtr data)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetVolumeFractionRange_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_InverseNormalOff_15(HandleRef pThis);

		public virtual void InverseNormalOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_InverseNormalOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_InverseNormalOn_16(HandleRef pThis);

		public virtual void InverseNormalOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_InverseNormalOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkYoungsMaterialInterface_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkYoungsMaterialInterface_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkYoungsMaterialInterface NewInstance()
		{
			vtkYoungsMaterialInterface result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_OnionPeelOff_21(HandleRef pThis);

		public virtual void OnionPeelOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_OnionPeelOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_OnionPeelOn_22(HandleRef pThis);

		public virtual void OnionPeelOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_OnionPeelOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_RemoveAllMaterials_23(HandleRef pThis);

		public virtual void RemoveAllMaterials()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_RemoveAllMaterials_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOff_24(HandleRef pThis);

		public virtual void ReverseMaterialOrderOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_ReverseMaterialOrderOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOn_25(HandleRef pThis);

		public virtual void ReverseMaterialOrderOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_ReverseMaterialOrderOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkYoungsMaterialInterface_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkYoungsMaterialInterface SafeDownCast(vtkObjectBase o)
		{
			vtkYoungsMaterialInterface vtkYoungsMaterialInterface = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkYoungsMaterialInterface = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkYoungsMaterialInterface.Register(null);
				}
			}
			return vtkYoungsMaterialInterface;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetAxisSymetric_27(HandleRef pThis, int _arg);

		public virtual void SetAxisSymetric(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetAxisSymetric_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetFillMaterial_28(HandleRef pThis, int _arg);

		public virtual void SetFillMaterial(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetFillMaterial_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetInverseNormal_29(HandleRef pThis, int _arg);

		public virtual void SetInverseNormal(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetInverseNormal_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialArrays_30(HandleRef pThis, int i, string volumeFraction, string interfaceNormal, string materialOrdering);

		public virtual void SetMaterialArrays(int i, string volumeFraction, string interfaceNormal, string materialOrdering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialArrays_30(base.GetCppThis(), i, volumeFraction, interfaceNormal, materialOrdering);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialNormalArray_31(HandleRef pThis, int i, string normal);

		public virtual void SetMaterialNormalArray(int i, string normal)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialNormalArray_31(base.GetCppThis(), i, normal);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialOrderingArray_32(HandleRef pThis, int i, string ordering);

		public virtual void SetMaterialOrderingArray(int i, string ordering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialOrderingArray_32(base.GetCppThis(), i, ordering);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_33(HandleRef pThis, int i, string volume);

		public virtual void SetMaterialVolumeFractionArray(int i, string volume)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_33(base.GetCppThis(), i, volume);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetNumberOfMaterials_34(HandleRef pThis, int n);

		public virtual void SetNumberOfMaterials(int n)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetNumberOfMaterials_34(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetOnionPeel_35(HandleRef pThis, int _arg);

		public virtual void SetOnionPeel(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetOnionPeel_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetReverseMaterialOrder_36(HandleRef pThis, int _arg);

		public virtual void SetReverseMaterialOrder(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetReverseMaterialOrder_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetTwoMaterialsOptimization_37(HandleRef pThis, int _arg);

		public virtual void SetTwoMaterialsOptimization(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetTwoMaterialsOptimization_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetUseFractionAsDistance_38(HandleRef pThis, int _arg);

		public virtual void SetUseFractionAsDistance(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetUseFractionAsDistance_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_39(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetVolumeFractionRange(double _arg1, double _arg2)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetVolumeFractionRange_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_40(HandleRef pThis, IntPtr _arg);

		public void SetVolumeFractionRange(IntPtr _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetVolumeFractionRange_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_TwoMaterialsOptimizationOff_41(HandleRef pThis);

		public virtual void TwoMaterialsOptimizationOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_TwoMaterialsOptimizationOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_TwoMaterialsOptimizationOn_42(HandleRef pThis);

		public virtual void TwoMaterialsOptimizationOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_TwoMaterialsOptimizationOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOff_43(HandleRef pThis);

		public virtual void UseFractionAsDistanceOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseFractionAsDistanceOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOn_44(HandleRef pThis);

		public virtual void UseFractionAsDistanceOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseFractionAsDistanceOn_44(base.GetCppThis());
		}
	}
}
