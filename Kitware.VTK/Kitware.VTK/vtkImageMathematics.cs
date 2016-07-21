using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMathematics : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMathematics";

		public new static readonly string MRClassNameKey;

		static vtkImageMathematics()
		{
			vtkImageMathematics.MRClassNameKey = "class vtkImageMathematics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMathematics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMathematics"));
		}

		public vtkImageMathematics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMathematics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMathematics New()
		{
			vtkImageMathematics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMathematics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMathematics.vtkImageMathematics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_DivideByZeroToCOff_01(HandleRef pThis);

		public virtual void DivideByZeroToCOff()
		{
			vtkImageMathematics.vtkImageMathematics_DivideByZeroToCOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_DivideByZeroToCOn_02(HandleRef pThis);

		public virtual void DivideByZeroToCOn()
		{
			vtkImageMathematics.vtkImageMathematics_DivideByZeroToCOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMathematics_GetConstantC_03(HandleRef pThis);

		public virtual double GetConstantC()
		{
			return vtkImageMathematics.vtkImageMathematics_GetConstantC_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMathematics_GetConstantK_04(HandleRef pThis);

		public virtual double GetConstantK()
		{
			return vtkImageMathematics.vtkImageMathematics_GetConstantK_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMathematics_GetDivideByZeroToC_05(HandleRef pThis);

		public virtual int GetDivideByZeroToC()
		{
			return vtkImageMathematics.vtkImageMathematics_GetDivideByZeroToC_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMathematics_GetOperation_06(HandleRef pThis);

		public virtual int GetOperation()
		{
			return vtkImageMathematics.vtkImageMathematics_GetOperation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMathematics_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMathematics_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMathematics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMathematics NewInstance()
		{
			vtkImageMathematics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMathematics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMathematics SafeDownCast(vtkObjectBase o)
		{
			vtkImageMathematics vtkImageMathematics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMathematics = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMathematics.Register(null);
				}
			}
			return vtkImageMathematics;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetConstantC_12(HandleRef pThis, double _arg);

		public virtual void SetConstantC(double _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetConstantC_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetConstantK_13(HandleRef pThis, double _arg);

		public virtual void SetConstantK(double _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetConstantK_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetDivideByZeroToC_14(HandleRef pThis, int _arg);

		public virtual void SetDivideByZeroToC(int _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetDivideByZeroToC_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetInput1_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput1(vtkDataObject arg0)
		{
			vtkImageMathematics.vtkImageMathematics_SetInput1_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetInput2_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput2(vtkDataObject arg0)
		{
			vtkImageMathematics.vtkImageMathematics_SetInput2_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperation_17(HandleRef pThis, int _arg);

		public virtual void SetOperation(int _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetOperation_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToATAN_18(HandleRef pThis);

		public void SetOperationToATAN()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToATAN_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToATAN2_19(HandleRef pThis);

		public void SetOperationToATAN2()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToATAN2_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToAbsoluteValue_20(HandleRef pThis);

		public void SetOperationToAbsoluteValue()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAbsoluteValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToAdd_21(HandleRef pThis);

		public void SetOperationToAdd()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAdd_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToAddConstant_22(HandleRef pThis);

		public void SetOperationToAddConstant()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAddConstant_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToComplexMultiply_23(HandleRef pThis);

		public void SetOperationToComplexMultiply()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToComplexMultiply_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToConjugate_24(HandleRef pThis);

		public void SetOperationToConjugate()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToConjugate_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToCos_25(HandleRef pThis);

		public void SetOperationToCos()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToCos_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToDivide_26(HandleRef pThis);

		public void SetOperationToDivide()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToDivide_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToExp_27(HandleRef pThis);

		public void SetOperationToExp()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToExp_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToInvert_28(HandleRef pThis);

		public void SetOperationToInvert()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToInvert_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToLog_29(HandleRef pThis);

		public void SetOperationToLog()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToLog_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToMax_30(HandleRef pThis);

		public void SetOperationToMax()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMax_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToMin_31(HandleRef pThis);

		public void SetOperationToMin()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMin_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToMultiply_32(HandleRef pThis);

		public void SetOperationToMultiply()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMultiply_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToMultiplyByK_33(HandleRef pThis);

		public void SetOperationToMultiplyByK()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMultiplyByK_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToReplaceCByK_34(HandleRef pThis);

		public void SetOperationToReplaceCByK()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToReplaceCByK_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToSin_35(HandleRef pThis);

		public void SetOperationToSin()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSin_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToSquare_36(HandleRef pThis);

		public void SetOperationToSquare()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSquare_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToSquareRoot_37(HandleRef pThis);

		public void SetOperationToSquareRoot()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSquareRoot_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMathematics_SetOperationToSubtract_38(HandleRef pThis);

		public void SetOperationToSubtract()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSubtract_38(base.GetCppThis());
		}
	}
}
