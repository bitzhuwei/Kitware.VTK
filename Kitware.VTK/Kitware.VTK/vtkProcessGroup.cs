using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProcessGroup : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcessGroup";

		public new static readonly string MRClassNameKey;

		static vtkProcessGroup()
		{
			vtkProcessGroup.MRClassNameKey = "class vtkProcessGroup";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcessGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessGroup"));
		}

		public vtkProcessGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcessGroup New()
		{
			vtkProcessGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProcessGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProcessGroup.vtkProcessGroup_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_AddProcessId_01(HandleRef pThis, int processId);

		public int AddProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_AddProcessId_01(base.GetCppThis(), processId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessGroup_Copy_02(HandleRef pThis, HandleRef group);

		public void Copy(vtkProcessGroup group)
		{
			vtkProcessGroup.vtkProcessGroup_Copy_02(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_FindProcessId_03(HandleRef pThis, int processId);

		public int FindProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_FindProcessId_03(base.GetCppThis(), processId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessGroup_GetCommunicator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCommunicator GetCommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_GetCommunicator_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunicator = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunicator.Register(null);
				}
			}
			return vtkCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_GetLocalProcessId_05(HandleRef pThis);

		public int GetLocalProcessId()
		{
			return vtkProcessGroup.vtkProcessGroup_GetLocalProcessId_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_GetNumberOfProcessIds_06(HandleRef pThis);

		public virtual int GetNumberOfProcessIds()
		{
			return vtkProcessGroup.vtkProcessGroup_GetNumberOfProcessIds_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_GetProcessId_07(HandleRef pThis, int pos);

		public int GetProcessId(int pos)
		{
			return vtkProcessGroup.vtkProcessGroup_GetProcessId_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessGroup_Initialize_08(HandleRef pThis, HandleRef controller);

		public void Initialize(vtkMultiProcessController controller)
		{
			vtkProcessGroup.vtkProcessGroup_Initialize_08(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessGroup_Initialize_09(HandleRef pThis, HandleRef communicator);

		public void Initialize(vtkCommunicator communicator)
		{
			vtkProcessGroup.vtkProcessGroup_Initialize_09(base.GetCppThis(), (communicator == null) ? default(HandleRef) : communicator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessGroup_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProcessGroup NewInstance()
		{
			vtkProcessGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessGroup_RemoveAllProcessIds_14(HandleRef pThis);

		public void RemoveAllProcessIds()
		{
			vtkProcessGroup.vtkProcessGroup_RemoveAllProcessIds_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessGroup_RemoveProcessId_15(HandleRef pThis, int processId);

		public int RemoveProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_RemoveProcessId_15(base.GetCppThis(), processId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessGroup_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcessGroup SafeDownCast(vtkObjectBase o)
		{
			vtkProcessGroup vtkProcessGroup = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkProcessGroup_SetCommunicator_17(HandleRef pThis, HandleRef communicator);

		public void SetCommunicator(vtkCommunicator communicator)
		{
			vtkProcessGroup.vtkProcessGroup_SetCommunicator_17(base.GetCppThis(), (communicator == null) ? default(HandleRef) : communicator.GetCppThis());
		}
	}
}
