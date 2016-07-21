using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRemoveHiddenData : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveHiddenData";

		public new static readonly string MRClassNameKey;

		static vtkRemoveHiddenData()
		{
			vtkRemoveHiddenData.MRClassNameKey = "class vtkRemoveHiddenData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveHiddenData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveHiddenData"));
		}

		public vtkRemoveHiddenData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveHiddenData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRemoveHiddenData New()
		{
			vtkRemoveHiddenData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRemoveHiddenData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRemoveHiddenData.vtkRemoveHiddenData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRemoveHiddenData_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRemoveHiddenData_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveHiddenData_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRemoveHiddenData NewInstance()
		{
			vtkRemoveHiddenData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveHiddenData_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRemoveHiddenData SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveHiddenData vtkRemoveHiddenData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveHiddenData = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveHiddenData.Register(null);
				}
			}
			return vtkRemoveHiddenData;
		}
	}
}
