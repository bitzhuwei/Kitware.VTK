using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableBasedClipDataSet : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableBasedClipDataSet";

		public new static readonly string MRClassNameKey;

		static vtkTableBasedClipDataSet()
		{
			vtkTableBasedClipDataSet.MRClassNameKey = "class vtkTableBasedClipDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableBasedClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableBasedClipDataSet"));
		}

		public vtkTableBasedClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableBasedClipDataSet New()
		{
			vtkTableBasedClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableBasedClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableBasedClipDataSet_GetGenerateClipScalars_08(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetGenerateClipScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableBasedClipDataSet_GetGenerateClippedOutput_09(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableBasedClipDataSet_GetInsideOut_10(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetInsideOut_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetLocator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkTableBasedClipDataSet_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTableBasedClipDataSet_GetMergeTolerance_13(HandleRef pThis);

		public virtual double GetMergeTolerance()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeTolerance_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_14(HandleRef pThis);

		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMinValue_15(HandleRef pThis);

		public virtual double GetMergeToleranceMinValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeToleranceMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkTableBasedClipDataSet_GetUseValueAsOffset_16(HandleRef pThis);

		public virtual bool GetUseValueAsOffset()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetUseValueAsOffset_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTableBasedClipDataSet_GetValue_17(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_InsideOutOff_18(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_InsideOutOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_InsideOutOn_19(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_InsideOutOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableBasedClipDataSet_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableBasedClipDataSet_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableBasedClipDataSet NewInstance()
		{
			vtkTableBasedClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableBasedClipDataSet_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableBasedClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkTableBasedClipDataSet vtkTableBasedClipDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableBasedClipDataSet = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableBasedClipDataSet.Register(null);
				}
			}
			return vtkTableBasedClipDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetClipFunction_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetClipFunction_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetGenerateClipScalars_26(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetGenerateClipScalars_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetGenerateClippedOutput_27(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetGenerateClippedOutput_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetInsideOut_28(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetInsideOut_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetLocator_29(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetLocator_29(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetMergeTolerance_30(HandleRef pThis, double _arg);

		public virtual void SetMergeTolerance(double _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetMergeTolerance_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetUseValueAsOffset_31(HandleRef pThis, byte _arg);

		public virtual void SetUseValueAsOffset(bool _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetUseValueAsOffset_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_SetValue_32(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetValue_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOff_33(HandleRef pThis);

		public virtual void UseValueAsOffsetOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_UseValueAsOffsetOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOn_34(HandleRef pThis);

		public virtual void UseValueAsOffsetOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_UseValueAsOffsetOn_34(base.GetCppThis());
		}
	}
}
