using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSocketController : vtkMultiProcessController
	{
		public new enum Consts
		{
			ENDIAN_TAG = 1010580540,
			HASH_TAG = 1061109567,
			IDTYPESIZE_TAG = 1027423549,
			VERSION_TAG = 1044266558
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketController";

		public new static readonly string MRClassNameKey;

		static vtkSocketController()
		{
			vtkSocketController.MRClassNameKey = "class vtkSocketController";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketController"));
		}

		public vtkSocketController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketController_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketController New()
		{
			vtkSocketController result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketController.vtkSocketController_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSocketController() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSocketController.vtkSocketController_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_CloseConnection_01(HandleRef pThis);

		public virtual void CloseConnection()
		{
			vtkSocketController.vtkSocketController_CloseConnection_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketController_ConnectTo_02(HandleRef pThis, string hostName, int port);

		public virtual int ConnectTo(string hostName, int port)
		{
			return vtkSocketController.vtkSocketController_ConnectTo_02(base.GetCppThis(), hostName, port);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketController_CreateCompliantController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMultiProcessController CreateCompliantController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketController.vtkSocketController_CreateCompliantController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_CreateOutputWindow_04(HandleRef pThis);

		public override void CreateOutputWindow()
		{
			vtkSocketController.vtkSocketController_CreateOutputWindow_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_Finalize_05(HandleRef pThis);

		public override void FinalizeWrapper()
		{
			vtkSocketController.vtkSocketController_Finalize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_Finalize_06(HandleRef pThis, int arg0);

		public override void FinalizeWrapper(int arg0)
		{
			vtkSocketController.vtkSocketController_Finalize_06(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketController_GetSwapBytesInReceivedData_07(HandleRef pThis);

		public int GetSwapBytesInReceivedData()
		{
			return vtkSocketController.vtkSocketController_GetSwapBytesInReceivedData_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_Initialize_08(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkSocketController.vtkSocketController_Initialize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketController_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSocketController.vtkSocketController_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketController_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSocketController.vtkSocketController_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_MultipleMethodExecute_11(HandleRef pThis);

		public override void MultipleMethodExecute()
		{
			vtkSocketController.vtkSocketController_MultipleMethodExecute_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketController_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSocketController NewInstance()
		{
			vtkSocketController result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketController.vtkSocketController_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketController_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketController SafeDownCast(vtkObjectBase o)
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketController.vtkSocketController_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketController = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketController.Register(null);
				}
			}
			return vtkSocketController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_SetCommunicator_15(HandleRef pThis, HandleRef comm);

		public void SetCommunicator(vtkSocketCommunicator comm)
		{
			vtkSocketController.vtkSocketController_SetCommunicator_15(base.GetCppThis(), (comm == null) ? default(HandleRef) : comm.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketController_SingleMethodExecute_16(HandleRef pThis);

		public override void SingleMethodExecute()
		{
			vtkSocketController.vtkSocketController_SingleMethodExecute_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketController_WaitForConnection_17(HandleRef pThis, int port);

		public virtual int WaitForConnection(int port)
		{
			return vtkSocketController.vtkSocketController_WaitForConnection_17(base.GetCppThis(), port);
		}
	}
}
