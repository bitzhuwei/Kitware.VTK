using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDSPFilterDefinition : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterDefinition";

		public new static readonly string MRClassNameKey;

		static vtkDSPFilterDefinition()
		{
			vtkDSPFilterDefinition.MRClassNameKey = "class vtkDSPFilterDefinition";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDSPFilterDefinition.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterDefinition"));
		}

		public vtkDSPFilterDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDSPFilterDefinition New()
		{
			vtkDSPFilterDefinition result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDSPFilterDefinition() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDSPFilterDefinition.vtkDSPFilterDefinition_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_Clear_01(HandleRef pThis);

		public void Clear()
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_Clear_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_Copy_02(HandleRef pThis, HandleRef other);

		public void Copy(vtkDSPFilterDefinition other)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_Copy_02(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkDSPFilterDefinition_GetDenominatorWeight_03(HandleRef pThis, int a_which);

		public double GetDenominatorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetDenominatorWeight_03(base.GetCppThis(), a_which);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(HandleRef pThis, int a_which);

		public double GetForwardNumeratorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(base.GetCppThis(), a_which);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterDefinition_GetInputVariableName_05(HandleRef pThis);

		public string GetInputVariableName()
		{
			return Marshal.PtrToStringAnsi(vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetInputVariableName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterDefinition_GetNumDenominatorWeights_06(HandleRef pThis);

		public int GetNumDenominatorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumDenominatorWeights_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(HandleRef pThis);

		public int GetNumForwardNumeratorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterDefinition_GetNumNumeratorWeights_08(HandleRef pThis);

		public int GetNumNumeratorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumNumeratorWeights_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkDSPFilterDefinition_GetNumeratorWeight_09(HandleRef pThis, int a_which);

		public double GetNumeratorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumeratorWeight_09(base.GetCppThis(), a_which);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterDefinition_GetOutputVariableName_10(HandleRef pThis);

		public string GetOutputVariableName()
		{
			return Marshal.PtrToStringAnsi(vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetOutputVariableName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterDefinition_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern byte vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_12(HandleRef pThis, int a_timestep, int a_outputTimestep);

		public bool IsThisInputVariableInstanceNeeded(int a_timestep, int a_outputTimestep)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_12(base.GetCppThis(), a_timestep, a_outputTimestep) != 0;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterDefinition_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterDefinition_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDSPFilterDefinition NewInstance()
		{
			vtkDSPFilterDefinition result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_PushBackDenominatorWeight_16(HandleRef pThis, double a_value);

		public void PushBackDenominatorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackDenominatorWeight_16(base.GetCppThis(), a_value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_17(HandleRef pThis, double a_value);

		public void PushBackForwardNumeratorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_17(base.GetCppThis(), a_value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_PushBackNumeratorWeight_18(HandleRef pThis, double a_value);

		public void PushBackNumeratorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackNumeratorWeight_18(base.GetCppThis(), a_value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterDefinition_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDSPFilterDefinition SafeDownCast(vtkObjectBase o)
		{
			vtkDSPFilterDefinition vtkDSPFilterDefinition = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDSPFilterDefinition = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDSPFilterDefinition.Register(null);
				}
			}
			return vtkDSPFilterDefinition;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_SetInputVariableName_20(HandleRef pThis, string a_value);

		public void SetInputVariableName(string a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_SetInputVariableName_20(base.GetCppThis(), a_value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterDefinition_SetOutputVariableName_21(HandleRef pThis, string a_value);

		public void SetOutputVariableName(string a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_SetOutputVariableName_21(base.GetCppThis(), a_value);
		}
	}
}
