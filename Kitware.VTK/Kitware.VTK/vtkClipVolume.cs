using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipVolume : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipVolume";

		public new static readonly string MRClassNameKey;

		static vtkClipVolume()
		{
			vtkClipVolume.MRClassNameKey = "class vtkClipVolume";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipVolume"));
		}

		public vtkClipVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipVolume New()
		{
			vtkClipVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipVolume.vtkClipVolume_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkClipVolume.vtkClipVolume_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkClipVolume.vtkClipVolume_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkClipVolume.vtkClipVolume_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkClipVolume.vtkClipVolume_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkClipVolume.vtkClipVolume_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipVolume_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkClipVolume_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkClipVolume_GetGenerateClipScalars_08(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkClipVolume.vtkClipVolume_GetGenerateClipScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipVolume_GetGenerateClippedOutput_09(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipVolume.vtkClipVolume_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipVolume_GetInsideOut_10(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkClipVolume.vtkClipVolume_GetInsideOut_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipVolume_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_GetLocator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkClipVolume_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkClipVolume.vtkClipVolume_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipVolume_GetMergeTolerance_13(HandleRef pThis);

		public virtual double GetMergeTolerance()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeTolerance_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipVolume_GetMergeToleranceMaxValue_14(HandleRef pThis);

		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeToleranceMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipVolume_GetMergeToleranceMinValue_15(HandleRef pThis);

		public virtual double GetMergeToleranceMinValue()
		{
			return vtkClipVolume.vtkClipVolume_GetMergeToleranceMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipVolume_GetMixed3DCellGeneration_16(HandleRef pThis);

		public virtual int GetMixed3DCellGeneration()
		{
			return vtkClipVolume.vtkClipVolume_GetMixed3DCellGeneration_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipVolume_GetValue_17(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkClipVolume.vtkClipVolume_GetValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_InsideOutOff_18(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkClipVolume.vtkClipVolume_InsideOutOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_InsideOutOn_19(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkClipVolume.vtkClipVolume_InsideOutOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipVolume_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipVolume.vtkClipVolume_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipVolume_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipVolume.vtkClipVolume_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_Mixed3DCellGenerationOff_22(HandleRef pThis);

		public virtual void Mixed3DCellGenerationOff()
		{
			vtkClipVolume.vtkClipVolume_Mixed3DCellGenerationOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_Mixed3DCellGenerationOn_23(HandleRef pThis);

		public virtual void Mixed3DCellGenerationOn()
		{
			vtkClipVolume.vtkClipVolume_Mixed3DCellGenerationOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipVolume_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipVolume NewInstance()
		{
			vtkClipVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipVolume_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipVolume SafeDownCast(vtkObjectBase o)
		{
			vtkClipVolume vtkClipVolume = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipVolume.vtkClipVolume_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipVolume = (vtkClipVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipVolume.Register(null);
				}
			}
			return vtkClipVolume;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetClipFunction_27(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipVolume.vtkClipVolume_SetClipFunction_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetGenerateClipScalars_28(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetGenerateClipScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetGenerateClippedOutput_29(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetGenerateClippedOutput_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetInsideOut_30(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetInsideOut_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetLocator_31(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipVolume.vtkClipVolume_SetLocator_31(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetMergeTolerance_32(HandleRef pThis, double _arg);

		public virtual void SetMergeTolerance(double _arg)
		{
			vtkClipVolume.vtkClipVolume_SetMergeTolerance_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetMixed3DCellGeneration_33(HandleRef pThis, int _arg);

		public virtual void SetMixed3DCellGeneration(int _arg)
		{
			vtkClipVolume.vtkClipVolume_SetMixed3DCellGeneration_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipVolume_SetValue_34(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkClipVolume.vtkClipVolume_SetValue_34(base.GetCppThis(), _arg);
		}
	}
}
