using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGPUInfoList : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfoList";

		public new static readonly string MRClassNameKey;

		static vtkGPUInfoList()
		{
			vtkGPUInfoList.MRClassNameKey = "class vtkGPUInfoList";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUInfoList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfoList"));
		}

		public vtkGPUInfoList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfoList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUInfoList New()
		{
			vtkGPUInfoList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGPUInfoList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGPUInfoList.vtkGPUInfoList_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfoList_GetGPUInfo_01(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGPUInfo GetGPUInfo(int i)
		{
			vtkGPUInfo vtkGPUInfo = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_GetGPUInfo_01(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUInfo = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUInfo.Register(null);
				}
			}
			return vtkGPUInfo;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGPUInfoList_GetNumberOfGPUs_02(HandleRef pThis);

		public virtual int GetNumberOfGPUs()
		{
			return vtkGPUInfoList.vtkGPUInfoList_GetNumberOfGPUs_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGPUInfoList_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGPUInfoList_IsProbed_04(HandleRef pThis);

		public virtual bool IsProbed()
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsProbed_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGPUInfoList_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGPUInfoList.vtkGPUInfoList_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfoList_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGPUInfoList NewInstance()
		{
			vtkGPUInfoList result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGPUInfoList_Probe_08(HandleRef pThis);

		public virtual void Probe()
		{
			vtkGPUInfoList.vtkGPUInfoList_Probe_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfoList_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUInfoList SafeDownCast(vtkObjectBase o)
		{
			vtkGPUInfoList vtkGPUInfoList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfoList.vtkGPUInfoList_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUInfoList = (vtkGPUInfoList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUInfoList.Register(null);
				}
			}
			return vtkGPUInfoList;
		}
	}
}
