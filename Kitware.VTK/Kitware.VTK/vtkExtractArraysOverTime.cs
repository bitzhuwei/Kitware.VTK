using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractArraysOverTime : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractArraysOverTime";

		public new static readonly string MRClassNameKey;

		static vtkExtractArraysOverTime()
		{
			vtkExtractArraysOverTime.MRClassNameKey = "class vtkExtractArraysOverTime";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractArraysOverTime"));
		}

		public vtkExtractArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractArraysOverTime New()
		{
			vtkExtractArraysOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArraysOverTime.vtkExtractArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractArraysOverTime.vtkExtractArraysOverTime_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractArraysOverTime_GetNumberOfTimeSteps_01(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractArraysOverTime.vtkExtractArraysOverTime_GetNumberOfTimeSteps_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractArraysOverTime_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractArraysOverTime.vtkExtractArraysOverTime_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractArraysOverTime_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractArraysOverTime.vtkExtractArraysOverTime_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArraysOverTime_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractArraysOverTime NewInstance()
		{
			vtkExtractArraysOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArraysOverTime.vtkExtractArraysOverTime_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArraysOverTime_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractArraysOverTime vtkExtractArraysOverTime = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArraysOverTime.vtkExtractArraysOverTime_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractArraysOverTime = (vtkExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractArraysOverTime.Register(null);
				}
			}
			return vtkExtractArraysOverTime;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractArraysOverTime_SetSelectionConnection_07(HandleRef pThis, HandleRef algOutput);

		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractArraysOverTime.vtkExtractArraysOverTime_SetSelectionConnection_07(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}
	}
}
