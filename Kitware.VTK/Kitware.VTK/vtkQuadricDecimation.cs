using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadricDecimation : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricDecimation";

		public new static readonly string MRClassNameKey;

		static vtkQuadricDecimation()
		{
			vtkQuadricDecimation.MRClassNameKey = "class vtkQuadricDecimation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricDecimation"));
		}

		public vtkQuadricDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricDecimation New()
		{
			vtkQuadricDecimation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadricDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadricDecimation.vtkQuadricDecimation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_AttributeErrorMetricOff_01(HandleRef pThis);

		public virtual void AttributeErrorMetricOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_AttributeErrorMetricOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_AttributeErrorMetricOn_02(HandleRef pThis);

		public virtual void AttributeErrorMetricOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_AttributeErrorMetricOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetActualReduction_03(HandleRef pThis);

		public virtual double GetActualReduction()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetActualReduction_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetAttributeErrorMetric_04(HandleRef pThis);

		public virtual int GetAttributeErrorMetric()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetAttributeErrorMetric_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetNormalsAttribute_05(HandleRef pThis);

		public virtual int GetNormalsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNormalsAttribute_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetNormalsWeight_06(HandleRef pThis);

		public virtual double GetNormalsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNormalsWeight_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetScalarsAttribute_07(HandleRef pThis);

		public virtual int GetScalarsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetScalarsAttribute_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetScalarsWeight_08(HandleRef pThis);

		public virtual double GetScalarsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetScalarsWeight_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetTCoordsAttribute_09(HandleRef pThis);

		public virtual int GetTCoordsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTCoordsAttribute_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetTCoordsWeight_10(HandleRef pThis);

		public virtual double GetTCoordsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTCoordsWeight_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetTargetReduction_11(HandleRef pThis);

		public virtual double GetTargetReduction()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReduction_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetTargetReductionMaxValue_12(HandleRef pThis);

		public virtual double GetTargetReductionMaxValue()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReductionMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetTargetReductionMinValue_13(HandleRef pThis);

		public virtual double GetTargetReductionMinValue()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReductionMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetTensorsAttribute_14(HandleRef pThis);

		public virtual int GetTensorsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTensorsAttribute_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetTensorsWeight_15(HandleRef pThis);

		public virtual double GetTensorsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTensorsWeight_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_GetVectorsAttribute_16(HandleRef pThis);

		public virtual int GetVectorsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetVectorsAttribute_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkQuadricDecimation_GetVectorsWeight_17(HandleRef pThis);

		public virtual double GetVectorsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetVectorsWeight_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadricDecimation_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricDecimation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadricDecimation NewInstance()
		{
			vtkQuadricDecimation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_NormalsAttributeOff_22(HandleRef pThis);

		public virtual void NormalsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_NormalsAttributeOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_NormalsAttributeOn_23(HandleRef pThis);

		public virtual void NormalsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_NormalsAttributeOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricDecimation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricDecimation vtkQuadricDecimation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricDecimation = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricDecimation.Register(null);
				}
			}
			return vtkQuadricDecimation;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_ScalarsAttributeOff_25(HandleRef pThis);

		public virtual void ScalarsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_ScalarsAttributeOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_ScalarsAttributeOn_26(HandleRef pThis);

		public virtual void ScalarsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_ScalarsAttributeOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetAttributeErrorMetric_27(HandleRef pThis, int _arg);

		public virtual void SetAttributeErrorMetric(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetAttributeErrorMetric_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetNormalsAttribute_28(HandleRef pThis, int _arg);

		public virtual void SetNormalsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetNormalsAttribute_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetNormalsWeight_29(HandleRef pThis, double _arg);

		public virtual void SetNormalsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetNormalsWeight_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetScalarsAttribute_30(HandleRef pThis, int _arg);

		public virtual void SetScalarsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetScalarsAttribute_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetScalarsWeight_31(HandleRef pThis, double _arg);

		public virtual void SetScalarsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetScalarsWeight_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetTCoordsAttribute_32(HandleRef pThis, int _arg);

		public virtual void SetTCoordsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTCoordsAttribute_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetTCoordsWeight_33(HandleRef pThis, double _arg);

		public virtual void SetTCoordsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTCoordsWeight_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetTargetReduction_34(HandleRef pThis, double _arg);

		public virtual void SetTargetReduction(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTargetReduction_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetTensorsAttribute_35(HandleRef pThis, int _arg);

		public virtual void SetTensorsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTensorsAttribute_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetTensorsWeight_36(HandleRef pThis, double _arg);

		public virtual void SetTensorsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTensorsWeight_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetVectorsAttribute_37(HandleRef pThis, int _arg);

		public virtual void SetVectorsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetVectorsAttribute_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_SetVectorsWeight_38(HandleRef pThis, double _arg);

		public virtual void SetVectorsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetVectorsWeight_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_TCoordsAttributeOff_39(HandleRef pThis);

		public virtual void TCoordsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TCoordsAttributeOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_TCoordsAttributeOn_40(HandleRef pThis);

		public virtual void TCoordsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TCoordsAttributeOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_TensorsAttributeOff_41(HandleRef pThis);

		public virtual void TensorsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TensorsAttributeOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_TensorsAttributeOn_42(HandleRef pThis);

		public virtual void TensorsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TensorsAttributeOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_VectorsAttributeOff_43(HandleRef pThis);

		public virtual void VectorsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VectorsAttributeOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkQuadricDecimation_VectorsAttributeOn_44(HandleRef pThis);

		public virtual void VectorsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VectorsAttributeOn_44(base.GetCppThis());
		}
	}
}
