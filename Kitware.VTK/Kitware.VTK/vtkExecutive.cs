using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkExecutive : vtkObject
	{
		public enum RequestDownstream_WrapperEnum
		{
			RequestDownstream = 1,
			RequestUpstream = 0
		}

		public enum AfterForward_WrapperEnum
		{
			AfterForward = 1,
			BeforeForward = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutive";

		public new static readonly string MRClassNameKey;

		static vtkExecutive()
		{
			vtkExecutive.MRClassNameKey = "class vtkExecutive";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutive.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutive"));
		}

		public vtkExecutive(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutive_Register_24(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkExecutive.vtkExecutive_Register_24(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutive_UnRegister_29(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkExecutive.vtkExecutive_UnRegister_29(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey ALGORITHM_AFTER_FORWARD()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey ALGORITHM_BEFORE_FORWARD()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_ALGORITHM_DIRECTION_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey ALGORITHM_DIRECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_DIRECTION_03(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_CONSUMERS_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationExecutivePortVectorKey CONSUMERS()
		{
			vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_CONSUMERS_04(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortVectorKey = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortVectorKey.Register(null);
				}
			}
			return vtkInformationExecutivePortVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_FORWARD_DIRECTION_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FORWARD_DIRECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_FORWARD_DIRECTION_05(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_FROM_OUTPUT_PORT_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FROM_OUTPUT_PORT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_FROM_OUTPUT_PORT_06(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_GetAlgorithm_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithm GetAlgorithm()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetAlgorithm_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetInputData_08(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetInputData(int port, int connection)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputData_08(base.GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_GetInputExecutive_09(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExecutive GetInputExecutive(int port, int connection)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputExecutive_09(base.GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetInputInformation_10(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetInputInformation(int port, int connection)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputInformation_10(base.GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetInputInformation_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationVector GetInputInformation(int port)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputInformation_11(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_GetNumberOfInputConnections_12(HandleRef pThis, int port);

		public int GetNumberOfInputConnections(int port)
		{
			return vtkExecutive.vtkExecutive_GetNumberOfInputConnections_12(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_GetNumberOfInputPorts_13(HandleRef pThis);

		public int GetNumberOfInputPorts()
		{
			return vtkExecutive.vtkExecutive_GetNumberOfInputPorts_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_GetNumberOfOutputPorts_14(HandleRef pThis);

		public int GetNumberOfOutputPorts()
		{
			return vtkExecutive.vtkExecutive_GetNumberOfOutputPorts_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetOutputData_15(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetOutputData(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputData_15(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkExecutive_GetOutputInformation_16(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetOutputInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputInformation_16(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetOutputInformation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationVector GetOutputInformation()
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputInformation_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_GetProducerPort_18(HandleRef pThis, HandleRef arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetProducerPort(vtkDataObject arg0)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetProducerPort_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExecutive.vtkExecutive_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExecutive.vtkExecutive_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_KEYS_TO_COPY_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKeyVectorKey KEYS_TO_COPY()
		{
			vtkInformationKeyVectorKey vtkInformationKeyVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_KEYS_TO_COPY_21(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyVectorKey = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyVectorKey.Register(null);
				}
			}
			return vtkInformationKeyVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExecutive NewInstance()
		{
			vtkExecutive result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_PRODUCER_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationExecutivePortKey PRODUCER()
		{
			vtkInformationExecutivePortKey vtkInformationExecutivePortKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_PRODUCER_23(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortKey = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortKey.Register(null);
				}
			}
			return vtkInformationExecutivePortKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExecutive_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExecutive SafeDownCast(vtkObjectBase o)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExecutive.vtkExecutive_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutive_SetOutputData_26(HandleRef pThis, int port, HandleRef arg1, HandleRef info);

		public virtual void SetOutputData(int port, vtkDataObject arg1, vtkInformation info)
		{
			vtkExecutive.vtkExecutive_SetOutputData_26(base.GetCppThis(), port, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutive_SetOutputData_27(HandleRef pThis, int port, HandleRef arg1);

		public virtual void SetOutputData(int port, vtkDataObject arg1)
		{
			vtkExecutive.vtkExecutive_SetOutputData_27(base.GetCppThis(), port, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExecutive_SetSharedOutputInformation_28(HandleRef pThis, HandleRef outInfoVec);

		public void SetSharedOutputInformation(vtkInformationVector outInfoVec)
		{
			vtkExecutive.vtkExecutive_SetSharedOutputInformation_28(base.GetCppThis(), (outInfoVec == null) ? default(HandleRef) : outInfoVec.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_Update_30(HandleRef pThis);

		public virtual int Update()
		{
			return vtkExecutive.vtkExecutive_Update_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExecutive_Update_31(HandleRef pThis, int port);

		public virtual int Update(int port)
		{
			return vtkExecutive.vtkExecutive_Update_31(base.GetCppThis(), port);
		}
	}
}
