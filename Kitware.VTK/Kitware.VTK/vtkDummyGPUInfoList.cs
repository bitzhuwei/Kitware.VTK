using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDummyGPUInfoList : vtkGPUInfoList
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyGPUInfoList";

		public new static readonly string MRClassNameKey;

		static vtkDummyGPUInfoList()
		{
			vtkDummyGPUInfoList.MRClassNameKey = "class vtkDummyGPUInfoList";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyGPUInfoList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyGPUInfoList"));
		}

		public vtkDummyGPUInfoList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyGPUInfoList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyGPUInfoList New()
		{
			vtkDummyGPUInfoList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDummyGPUInfoList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDummyGPUInfoList.vtkDummyGPUInfoList_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDummyGPUInfoList_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDummyGPUInfoList_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDummyGPUInfoList.vtkDummyGPUInfoList_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyGPUInfoList_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDummyGPUInfoList NewInstance()
		{
			vtkDummyGPUInfoList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDummyGPUInfoList_Probe_05(HandleRef pThis);

		public override void Probe()
		{
			vtkDummyGPUInfoList.vtkDummyGPUInfoList_Probe_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyGPUInfoList_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyGPUInfoList SafeDownCast(vtkObjectBase o)
		{
			vtkDummyGPUInfoList vtkDummyGPUInfoList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyGPUInfoList.vtkDummyGPUInfoList_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyGPUInfoList = (vtkDummyGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyGPUInfoList.Register(null);
				}
			}
			return vtkDummyGPUInfoList;
		}
	}
}
