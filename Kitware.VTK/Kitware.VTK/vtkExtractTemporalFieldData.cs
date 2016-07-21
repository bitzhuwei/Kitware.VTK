using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractTemporalFieldData : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTemporalFieldData";

		public new static readonly string MRClassNameKey;

		static vtkExtractTemporalFieldData()
		{
			vtkExtractTemporalFieldData.MRClassNameKey = "class vtkExtractTemporalFieldData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractTemporalFieldData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTemporalFieldData"));
		}

		public vtkExtractTemporalFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTemporalFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractTemporalFieldData New()
		{
			vtkExtractTemporalFieldData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTemporalFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractTemporalFieldData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTemporalFieldData_GetNumberOfTimeSteps_01(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_GetNumberOfTimeSteps_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTemporalFieldData_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractTemporalFieldData_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTemporalFieldData_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractTemporalFieldData NewInstance()
		{
			vtkExtractTemporalFieldData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTemporalFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractTemporalFieldData_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractTemporalFieldData SafeDownCast(vtkObjectBase o)
		{
			vtkExtractTemporalFieldData vtkExtractTemporalFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractTemporalFieldData.vtkExtractTemporalFieldData_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractTemporalFieldData = (vtkExtractTemporalFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractTemporalFieldData.Register(null);
				}
			}
			return vtkExtractTemporalFieldData;
		}
	}
}
