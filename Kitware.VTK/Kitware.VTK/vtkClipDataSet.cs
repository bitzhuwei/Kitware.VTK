using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipDataSet : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipDataSet";

		public new static readonly string MRClassNameKey;

		static vtkClipDataSet()
		{
			vtkClipDataSet.MRClassNameKey = "class vtkClipDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipDataSet"));
		}

		public vtkClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipDataSet New()
		{
			vtkClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipDataSet.vtkClipDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkClipDataSet.vtkClipDataSet_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipDataSet_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkClipDataSet_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkClipDataSet_GetGenerateClipScalars_08(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkClipDataSet.vtkClipDataSet_GetGenerateClipScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipDataSet_GetGenerateClippedOutput_09(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipDataSet.vtkClipDataSet_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipDataSet_GetInsideOut_10(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkClipDataSet.vtkClipDataSet_GetInsideOut_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipDataSet_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetLocator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkClipDataSet_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipDataSet_GetMergeTolerance_13(HandleRef pThis);

		public virtual double GetMergeTolerance()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeTolerance_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipDataSet_GetMergeToleranceMaxValue_14(HandleRef pThis);

		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeToleranceMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipDataSet_GetMergeToleranceMinValue_15(HandleRef pThis);

		public virtual double GetMergeToleranceMinValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeToleranceMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkClipDataSet_GetUseValueAsOffset_16(HandleRef pThis);

		public virtual bool GetUseValueAsOffset()
		{
			return vtkClipDataSet.vtkClipDataSet_GetUseValueAsOffset_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipDataSet_GetValue_17(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_InsideOutOff_18(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkClipDataSet.vtkClipDataSet_InsideOutOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_InsideOutOn_19(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkClipDataSet.vtkClipDataSet_InsideOutOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipDataSet_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipDataSet_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipDataSet_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipDataSet NewInstance()
		{
			vtkClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipDataSet_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkClipDataSet vtkClipDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipDataSet = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipDataSet.Register(null);
				}
			}
			return vtkClipDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetClipFunction_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipDataSet.vtkClipDataSet_SetClipFunction_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetGenerateClipScalars_26(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetGenerateClipScalars_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetGenerateClippedOutput_27(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetGenerateClippedOutput_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetInsideOut_28(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetInsideOut_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetLocator_29(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipDataSet.vtkClipDataSet_SetLocator_29(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetMergeTolerance_30(HandleRef pThis, double _arg);

		public virtual void SetMergeTolerance(double _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetMergeTolerance_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetUseValueAsOffset_31(HandleRef pThis, byte _arg);

		public virtual void SetUseValueAsOffset(bool _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetUseValueAsOffset_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_SetValue_32(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetValue_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_UseValueAsOffsetOff_33(HandleRef pThis);

		public virtual void UseValueAsOffsetOff()
		{
			vtkClipDataSet.vtkClipDataSet_UseValueAsOffsetOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipDataSet_UseValueAsOffsetOn_34(HandleRef pThis);

		public virtual void UseValueAsOffsetOn()
		{
			vtkClipDataSet.vtkClipDataSet_UseValueAsOffsetOn_34(base.GetCppThis());
		}
	}
}
