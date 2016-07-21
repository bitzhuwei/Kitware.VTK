using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHeap : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHeap";

		public new static readonly string MRClassNameKey;

		static vtkHeap()
		{
			vtkHeap.MRClassNameKey = "class vtkHeap";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHeap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHeap"));
		}

		public vtkHeap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHeap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHeap New()
		{
			vtkHeap result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHeap.vtkHeap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHeap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHeap.vtkHeap_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHeap_AllocateMemory_01(HandleRef pThis, uint n);

		public IntPtr AllocateMemory(uint n)
		{
			return vtkHeap.vtkHeap_AllocateMemory_01(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkHeap_GetBlockSize_02(HandleRef pThis);

		public virtual uint GetBlockSize()
		{
			return vtkHeap.vtkHeap_GetBlockSize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHeap_GetNumberOfAllocations_03(HandleRef pThis);

		public virtual int GetNumberOfAllocations()
		{
			return vtkHeap.vtkHeap_GetNumberOfAllocations_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHeap_GetNumberOfBlocks_04(HandleRef pThis);

		public virtual int GetNumberOfBlocks()
		{
			return vtkHeap.vtkHeap_GetNumberOfBlocks_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHeap_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHeap.vtkHeap_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHeap_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHeap.vtkHeap_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHeap_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHeap NewInstance()
		{
			vtkHeap result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHeap.vtkHeap_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkHeap_Reset_09(HandleRef pThis);

		public void Reset()
		{
			vtkHeap.vtkHeap_Reset_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHeap_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHeap SafeDownCast(vtkObjectBase o)
		{
			vtkHeap vtkHeap = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHeap.vtkHeap_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHeap = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHeap.Register(null);
				}
			}
			return vtkHeap;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkHeap_SetBlockSize_11(HandleRef pThis, uint arg0);

		public virtual void SetBlockSize(uint arg0)
		{
			vtkHeap.vtkHeap_SetBlockSize_11(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHeap_StringDup_12(HandleRef pThis, string str);

		public string StringDup(string str)
		{
			return Marshal.PtrToStringAnsi(vtkHeap.vtkHeap_StringDup_12(base.GetCppThis(), str));
		}
	}
}
