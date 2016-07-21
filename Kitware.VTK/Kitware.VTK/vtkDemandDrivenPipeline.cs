using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDemandDrivenPipeline : vtkExecutive
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDemandDrivenPipeline";

		public new static readonly string MRClassNameKey;

		static vtkDemandDrivenPipeline()
		{
			vtkDemandDrivenPipeline.MRClassNameKey = "class vtkDemandDrivenPipeline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDemandDrivenPipeline"));
		}

		public vtkDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDemandDrivenPipeline New()
		{
			vtkDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_NOT_GENERATED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDemandDrivenPipeline_GetPipelineMTime_02(HandleRef pThis);

		public virtual uint GetPipelineMTime()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetPipelineMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_GetReleaseDataFlag_03(HandleRef pThis, int port);

		public virtual int GetReleaseDataFlag(int port)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetReleaseDataFlag_03(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_NewDataObject_07(string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataObject NewDataObject(string type)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_NewDataObject_07(type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDemandDrivenPipeline NewInstance()
		{
			vtkDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_RELEASE_DATA_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey RELEASE_DATA()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_RELEASE_DATA_09(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_DATA()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_10(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_DATA_NOT_GENERATED()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_11(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_DATA_OBJECT()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_12(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_INFORMATION_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_INFORMATION()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_INFORMATION_13(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_REGENERATE_INFORMATION_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey REQUEST_REGENERATE_INFORMATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_REGENERATE_INFORMATION_14(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDemandDrivenPipeline_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkDemandDrivenPipeline vtkDemandDrivenPipeline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDemandDrivenPipeline = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDemandDrivenPipeline.Register(null);
				}
			}
			return vtkDemandDrivenPipeline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_SetReleaseDataFlag_16(HandleRef pThis, int port, int n);

		public virtual int SetReleaseDataFlag(int port, int n)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_SetReleaseDataFlag_16(base.GetCppThis(), port, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_Update_17(HandleRef pThis);

		public override int Update()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_Update_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_Update_18(HandleRef pThis, int port);

		public override int Update(int port)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_Update_18(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_UpdateData_19(HandleRef pThis, int outputPort);

		public virtual int UpdateData(int outputPort)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateData_19(base.GetCppThis(), outputPort);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_UpdateDataObject_20(HandleRef pThis);

		public virtual int UpdateDataObject()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateDataObject_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_UpdateInformation_21(HandleRef pThis);

		public virtual int UpdateInformation()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateInformation_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDemandDrivenPipeline_UpdatePipelineMTime_22(HandleRef pThis);

		public virtual int UpdatePipelineMTime()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdatePipelineMTime_22(base.GetCppThis());
		}
	}
}
