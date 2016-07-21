using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPriorityQueue : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPriorityQueue";

		public new static readonly string MRClassNameKey;

		static vtkPriorityQueue()
		{
			vtkPriorityQueue.MRClassNameKey = "class vtkPriorityQueue";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPriorityQueue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPriorityQueue"));
		}

		public vtkPriorityQueue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPriorityQueue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPriorityQueue New()
		{
			vtkPriorityQueue result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPriorityQueue() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPriorityQueue.vtkPriorityQueue_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPriorityQueue_Allocate_01(HandleRef pThis, long sz, long ext);

		public void Allocate(long sz, long ext)
		{
			vtkPriorityQueue.vtkPriorityQueue_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPriorityQueue_DeleteId_02(HandleRef pThis, long id);

		public double DeleteId(long id)
		{
			return vtkPriorityQueue.vtkPriorityQueue_DeleteId_02(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPriorityQueue_GetNumberOfItems_03(HandleRef pThis);

		public long GetNumberOfItems()
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetNumberOfItems_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPriorityQueue_GetPriority_04(HandleRef pThis, long id);

		public double GetPriority(long id)
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetPriority_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPriorityQueue_Insert_05(HandleRef pThis, double priority, long id);

		public void Insert(double priority, long id)
		{
			vtkPriorityQueue.vtkPriorityQueue_Insert_05(base.GetCppThis(), priority, id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPriorityQueue_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPriorityQueue_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPriorityQueue_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPriorityQueue NewInstance()
		{
			vtkPriorityQueue result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPriorityQueue_Peek_10(HandleRef pThis, long location, ref double priority);

		public long Peek(long location, ref double priority)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Peek_10(base.GetCppThis(), location, ref priority);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPriorityQueue_Peek_11(HandleRef pThis, long location);

		public long Peek(long location)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Peek_11(base.GetCppThis(), location);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPriorityQueue_Pop_12(HandleRef pThis, long location, ref double priority);

		public long Pop(long location, ref double priority)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Pop_12(base.GetCppThis(), location, ref priority);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPriorityQueue_Pop_13(HandleRef pThis, long location);

		public long Pop(long location)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Pop_13(base.GetCppThis(), location);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPriorityQueue_Reset_14(HandleRef pThis);

		public void Reset()
		{
			vtkPriorityQueue.vtkPriorityQueue_Reset_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPriorityQueue_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPriorityQueue SafeDownCast(vtkObjectBase o)
		{
			vtkPriorityQueue vtkPriorityQueue = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPriorityQueue = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPriorityQueue.Register(null);
				}
			}
			return vtkPriorityQueue;
		}
	}
}
