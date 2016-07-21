using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSubGroup : vtkObject
	{
		public enum MAXOP_WrapperEnum
		{
			MAXOP = 2,
			MINOP = 1,
			SUMOP = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSubGroup";

		public new static readonly string MRClassNameKey;

		static vtkSubGroup()
		{
			vtkSubGroup.MRClassNameKey = "class vtkSubGroup";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubGroup"));
		}

		public vtkSubGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubGroup New()
		{
			vtkSubGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSubGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSubGroup.vtkSubGroup_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Barrier_01(HandleRef pThis);

		public int Barrier()
		{
			return vtkSubGroup.vtkSubGroup_Barrier_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Broadcast_02(HandleRef pThis, IntPtr data, int length, int root);

		public int Broadcast(IntPtr data, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Broadcast_02(base.GetCppThis(), data, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Broadcast_03(HandleRef pThis, string data, int length, int root);

		public int Broadcast(string data, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Broadcast_03(base.GetCppThis(), data, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Gather_04(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		public int Gather(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Gather_04(base.GetCppThis(), data, to, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Gather_05(HandleRef pThis, string data, string to, int length, int root);

		public int Gather(string data, string to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Gather_05(base.GetCppThis(), data, to, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_Initialize_06(HandleRef pThis, int p0, int p1, int me, int tag, HandleRef c);

		public int Initialize(int p0, int p1, int me, int tag, vtkCommunicator c)
		{
			return vtkSubGroup.vtkSubGroup_Initialize_06(base.GetCppThis(), p0, p1, me, tag, (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSubGroup.vtkSubGroup_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSubGroup.vtkSubGroup_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubGroup_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSubGroup NewInstance()
		{
			vtkSubGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSubGroup_PrintSubGroup_11(HandleRef pThis);

		public void PrintSubGroup()
		{
			vtkSubGroup.vtkSubGroup_PrintSubGroup_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_ReduceMax_12(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		public int ReduceMax(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceMax_12(base.GetCppThis(), data, to, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_ReduceMin_13(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		public int ReduceMin(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceMin_13(base.GetCppThis(), data, to, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_ReduceSum_14(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		public int ReduceSum(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceSum_14(base.GetCppThis(), data, to, length, root);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubGroup_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubGroup SafeDownCast(vtkObjectBase o)
		{
			vtkSubGroup vtkSubGroup = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubGroup = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubGroup.Register(null);
				}
			}
			return vtkSubGroup;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubGroup_getLocalRank_16(HandleRef pThis, int processID);

		public int getLocalRank(int processID)
		{
			return vtkSubGroup.vtkSubGroup_getLocalRank_16(base.GetCppThis(), processID);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSubGroup_setGatherPattern_17(HandleRef pThis, int root, int length);

		public void setGatherPattern(int root, int length)
		{
			vtkSubGroup.vtkSubGroup_setGatherPattern_17(base.GetCppThis(), root, length);
		}
	}
}
