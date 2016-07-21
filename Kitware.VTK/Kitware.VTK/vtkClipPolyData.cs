using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipPolyData";

		public new static readonly string MRClassNameKey;

		static vtkClipPolyData()
		{
			vtkClipPolyData.MRClassNameKey = "class vtkClipPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipPolyData"));
		}

		public vtkClipPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipPolyData New()
		{
			vtkClipPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipPolyData.vtkClipPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkClipPolyData.vtkClipPolyData_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkClipPolyData.vtkClipPolyData_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPolyData_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkClipPolyData_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetClippedOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkClipPolyData_GetClippedOutputPort_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithmOutput GetClippedOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetClippedOutputPort_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipPolyData_GetGenerateClipScalars_09(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkClipPolyData.vtkClipPolyData_GetGenerateClipScalars_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipPolyData_GetGenerateClippedOutput_10(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipPolyData.vtkClipPolyData_GetGenerateClippedOutput_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipPolyData_GetInsideOut_11(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkClipPolyData.vtkClipPolyData_GetInsideOut_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPolyData_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_GetLocator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkClipPolyData_GetMTime_13(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkClipPolyData.vtkClipPolyData_GetMTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipPolyData_GetValue_14(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkClipPolyData.vtkClipPolyData_GetValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_InsideOutOff_15(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkClipPolyData.vtkClipPolyData_InsideOutOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_InsideOutOn_16(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkClipPolyData.vtkClipPolyData_InsideOutOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipPolyData_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipPolyData_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipPolyData.vtkClipPolyData_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPolyData_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipPolyData NewInstance()
		{
			vtkClipPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPolyData_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkClipPolyData vtkClipPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPolyData.vtkClipPolyData_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipPolyData = (vtkClipPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipPolyData.Register(null);
				}
			}
			return vtkClipPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetClipFunction_22(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipPolyData.vtkClipPolyData_SetClipFunction_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetGenerateClipScalars_23(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetGenerateClipScalars_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetGenerateClippedOutput_24(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetGenerateClippedOutput_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetInsideOut_25(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetInsideOut_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetLocator_26(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipPolyData.vtkClipPolyData_SetLocator_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipPolyData_SetValue_27(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkClipPolyData.vtkClipPolyData_SetValue_27(base.GetCppThis(), _arg);
		}
	}
}
