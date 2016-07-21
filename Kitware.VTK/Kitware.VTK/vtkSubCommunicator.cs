using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSubCommunicator : vtkCommunicator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubCommunicator";

		public new static readonly string MRClassNameKey;

		static vtkSubCommunicator()
		{
			vtkSubCommunicator.MRClassNameKey = "class vtkSubCommunicator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubCommunicator"));
		}

		public vtkSubCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubCommunicator New()
		{
			vtkSubCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSubCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSubCommunicator.vtkSubCommunicator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubCommunicator_GetGroup_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProcessGroup GetGroup()
		{
			vtkProcessGroup vtkProcessGroup = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_GetGroup_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessGroup = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessGroup.Register(null);
				}
			}
			return vtkProcessGroup;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubCommunicator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubCommunicator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubCommunicator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSubCommunicator NewInstance()
		{
			vtkSubCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubCommunicator_ReceiveVoidArray_06(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSubCommunicator.vtkSubCommunicator_ReceiveVoidArray_06(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSubCommunicator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkSubCommunicator vtkSubCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubCommunicator = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubCommunicator.Register(null);
				}
			}
			return vtkSubCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSubCommunicator_SendVoidArray_08(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSubCommunicator.vtkSubCommunicator_SendVoidArray_08(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSubCommunicator_SetGroup_09(HandleRef pThis, HandleRef group);

		public virtual void SetGroup(vtkProcessGroup group)
		{
			vtkSubCommunicator.vtkSubCommunicator_SetGroup_09(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis());
		}
	}
}
