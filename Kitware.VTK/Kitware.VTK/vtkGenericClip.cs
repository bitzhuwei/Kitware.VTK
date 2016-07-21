using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericClip : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericClip";

		public new static readonly string MRClassNameKey;

		static vtkGenericClip()
		{
			vtkGenericClip.MRClassNameKey = "class vtkGenericClip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericClip"));
		}

		public vtkGenericClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericClip New()
		{
			vtkGenericClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericClip.vtkGenericClip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGenericClip.vtkGenericClip_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkGenericClip.vtkGenericClip_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkGenericClip.vtkGenericClip_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkGenericClip.vtkGenericClip_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkGenericClip.vtkGenericClip_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_GetGenerateClipScalars_08(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkGenericClip.vtkGenericClip_GetGenerateClipScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_GetGenerateClippedOutput_09(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkGenericClip.vtkGenericClip_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_GetInputScalarsSelection_10(HandleRef pThis);

		public virtual string GetInputScalarsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericClip.vtkGenericClip_GetInputScalarsSelection_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_GetInsideOut_11(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkGenericClip.vtkGenericClip_GetInsideOut_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_GetLocator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericClip_GetMTime_13(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericClip.vtkGenericClip_GetMTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericClip_GetMergeTolerance_14(HandleRef pThis);

		public virtual double GetMergeTolerance()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeTolerance_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericClip_GetMergeToleranceMaxValue_15(HandleRef pThis);

		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeToleranceMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericClip_GetMergeToleranceMinValue_16(HandleRef pThis);

		public virtual double GetMergeToleranceMinValue()
		{
			return vtkGenericClip.vtkGenericClip_GetMergeToleranceMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_GetNumberOfOutputs_17(HandleRef pThis);

		public virtual int GetNumberOfOutputs()
		{
			return vtkGenericClip.vtkGenericClip_GetNumberOfOutputs_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericClip_GetValue_18(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkGenericClip.vtkGenericClip_GetValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_InsideOutOff_19(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkGenericClip.vtkGenericClip_InsideOutOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_InsideOutOn_20(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkGenericClip.vtkGenericClip_InsideOutOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericClip.vtkGenericClip_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericClip_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericClip.vtkGenericClip_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericClip NewInstance()
		{
			vtkGenericClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericClip_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericClip SafeDownCast(vtkObjectBase o)
		{
			vtkGenericClip vtkGenericClip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericClip.vtkGenericClip_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericClip = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericClip.Register(null);
				}
			}
			return vtkGenericClip;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SelectInputScalars_26(HandleRef pThis, string fieldName);

		public void SelectInputScalars(string fieldName)
		{
			vtkGenericClip.vtkGenericClip_SelectInputScalars_26(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetClipFunction_27(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkGenericClip.vtkGenericClip_SetClipFunction_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetGenerateClipScalars_28(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetGenerateClipScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetGenerateClippedOutput_29(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetGenerateClippedOutput_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetInsideOut_30(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkGenericClip.vtkGenericClip_SetInsideOut_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetLocator_31(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericClip.vtkGenericClip_SetLocator_31(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetMergeTolerance_32(HandleRef pThis, double _arg);

		public virtual void SetMergeTolerance(double _arg)
		{
			vtkGenericClip.vtkGenericClip_SetMergeTolerance_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericClip_SetValue_33(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkGenericClip.vtkGenericClip_SetValue_33(base.GetCppThis(), _arg);
		}
	}
}
