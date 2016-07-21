using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDummyController : vtkMultiProcessController
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyController";

		public new static readonly string MRClassNameKey;

		static vtkDummyController()
		{
			vtkDummyController.MRClassNameKey = "class vtkDummyController";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyController"));
		}

		public vtkDummyController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyController_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyController New()
		{
			vtkDummyController result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyController.vtkDummyController_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDummyController() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDummyController.vtkDummyController_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_CreateOutputWindow_01(HandleRef pThis);

		public override void CreateOutputWindow()
		{
			vtkDummyController.vtkDummyController_CreateOutputWindow_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_Finalize_02(HandleRef pThis);

		public override void FinalizeWrapper()
		{
			vtkDummyController.vtkDummyController_Finalize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_Finalize_03(HandleRef pThis, int arg0);

		public override void FinalizeWrapper(int arg0)
		{
			vtkDummyController.vtkDummyController_Finalize_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyController_GetCommunicator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCommunicator GetCommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyController.vtkDummyController_GetCommunicator_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDummyController_GetLocalProcessId_05(HandleRef pThis);

		public new int GetLocalProcessId()
		{
			return vtkDummyController.vtkDummyController_GetLocalProcessId_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyController_GetRMICommunicator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCommunicator GetRMICommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyController.vtkDummyController_GetRMICommunicator_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDummyController_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDummyController.vtkDummyController_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDummyController_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDummyController.vtkDummyController_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_MultipleMethodExecute_09(HandleRef pThis);

		public override void MultipleMethodExecute()
		{
			vtkDummyController.vtkDummyController_MultipleMethodExecute_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyController_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDummyController NewInstance()
		{
			vtkDummyController result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyController.vtkDummyController_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyController_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyController SafeDownCast(vtkObjectBase o)
		{
			vtkDummyController vtkDummyController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyController.vtkDummyController_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyController = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyController.Register(null);
				}
			}
			return vtkDummyController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_SetCommunicator_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetCommunicator(vtkCommunicator arg0)
		{
			vtkDummyController.vtkDummyController_SetCommunicator_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_SetRMICommunicator_14(HandleRef pThis, HandleRef arg0);

		public virtual void SetRMICommunicator(vtkCommunicator arg0)
		{
			vtkDummyController.vtkDummyController_SetRMICommunicator_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDummyController_SingleMethodExecute_15(HandleRef pThis);

		public override void SingleMethodExecute()
		{
			vtkDummyController.vtkDummyController_SingleMethodExecute_15(base.GetCppThis());
		}
	}
}
