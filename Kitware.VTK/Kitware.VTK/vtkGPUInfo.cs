using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGPUInfo : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfo";

		public new static readonly string MRClassNameKey;

		static vtkGPUInfo()
		{
			vtkGPUInfo.MRClassNameKey = "class vtkGPUInfo";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUInfo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfo"));
		}

		public vtkGPUInfo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUInfo New()
		{
			vtkGPUInfo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGPUInfo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGPUInfo.vtkGPUInfo_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkGPUInfo_GetDedicatedSystemMemory_01(HandleRef pThis);

		public virtual long GetDedicatedSystemMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetDedicatedSystemMemory_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkGPUInfo_GetDedicatedVideoMemory_02(HandleRef pThis);

		public virtual long GetDedicatedVideoMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetDedicatedVideoMemory_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkGPUInfo_GetSharedSystemMemory_03(HandleRef pThis);

		public virtual long GetSharedSystemMemory()
		{
			return vtkGPUInfo.vtkGPUInfo_GetSharedSystemMemory_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGPUInfo_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGPUInfo_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGPUInfo.vtkGPUInfo_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfo_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGPUInfo NewInstance()
		{
			vtkGPUInfo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUInfo_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUInfo SafeDownCast(vtkObjectBase o)
		{
			vtkGPUInfo vtkGPUInfo = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUInfo.vtkGPUInfo_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkGPUInfo_SetDedicatedSystemMemory_09(HandleRef pThis, long _arg);

		public virtual void SetDedicatedSystemMemory(long _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetDedicatedSystemMemory_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGPUInfo_SetDedicatedVideoMemory_10(HandleRef pThis, long _arg);

		public virtual void SetDedicatedVideoMemory(long _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetDedicatedVideoMemory_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGPUInfo_SetSharedSystemMemory_11(HandleRef pThis, long _arg);

		public virtual void SetSharedSystemMemory(long _arg)
		{
			vtkGPUInfo.vtkGPUInfo_SetSharedSystemMemory_11(base.GetCppThis(), _arg);
		}
	}
}
