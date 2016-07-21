using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDuplicatePolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDuplicatePolyData";

		public new static readonly string MRClassNameKey;

		static vtkDuplicatePolyData()
		{
			vtkDuplicatePolyData.MRClassNameKey = "class vtkDuplicatePolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDuplicatePolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDuplicatePolyData"));
		}

		public vtkDuplicatePolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDuplicatePolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDuplicatePolyData New()
		{
			vtkDuplicatePolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDuplicatePolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDuplicatePolyData.vtkDuplicatePolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDuplicatePolyData_GetClientFlag_01(HandleRef pThis);

		public virtual int GetClientFlag()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetClientFlag_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDuplicatePolyData_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkDuplicatePolyData_GetMemorySize_03(HandleRef pThis);

		public virtual uint GetMemorySize()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetMemorySize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDuplicatePolyData_GetSocketController_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_GetSocketController_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDuplicatePolyData_GetSynchronous_05(HandleRef pThis);

		public virtual int GetSynchronous()
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_GetSynchronous_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_InitializeSchedule_06(HandleRef pThis, int numProcs);

		public void InitializeSchedule(int numProcs)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_InitializeSchedule_06(base.GetCppThis(), numProcs);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDuplicatePolyData_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDuplicatePolyData_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDuplicatePolyData.vtkDuplicatePolyData_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDuplicatePolyData_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDuplicatePolyData NewInstance()
		{
			vtkDuplicatePolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDuplicatePolyData_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDuplicatePolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDuplicatePolyData vtkDuplicatePolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDuplicatePolyData.vtkDuplicatePolyData_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDuplicatePolyData = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDuplicatePolyData.Register(null);
				}
			}
			return vtkDuplicatePolyData;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SetClientFlag_12(HandleRef pThis, int _arg);

		public virtual void SetClientFlag(int _arg)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetClientFlag_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SetController_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetController_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SetSocketController_14(HandleRef pThis, HandleRef controller);

		public void SetSocketController(vtkSocketController controller)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetSocketController_14(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SetSynchronous_15(HandleRef pThis, int _arg);

		public virtual void SetSynchronous(int _arg)
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SetSynchronous_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SynchronousOff_16(HandleRef pThis);

		public virtual void SynchronousOff()
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SynchronousOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDuplicatePolyData_SynchronousOn_17(HandleRef pThis);

		public virtual void SynchronousOn()
		{
			vtkDuplicatePolyData.vtkDuplicatePolyData_SynchronousOn_17(base.GetCppThis());
		}
	}
}
