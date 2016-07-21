using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkStatisticsAlgorithm : vtkTableAlgorithm
	{
		public enum InputPorts
		{
			INPUT_DATA,
			INPUT_MODEL = 2,
			LEARN_PARAMETERS = 1
		}

		public enum OutputIndices
		{
			ASSESSMENT = 2,
			OUTPUT_DATA = 0,
			OUTPUT_MODEL,
			OUTPUT_TEST
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkStatisticsAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkStatisticsAlgorithm()
		{
			vtkStatisticsAlgorithm.MRClassNameKey = "class vtkStatisticsAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStatisticsAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStatisticsAlgorithm"));
		}

		public vtkStatisticsAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStatisticsAlgorithm_GetAssessNames_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetAssessNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetAssessNames_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStatisticsAlgorithm_GetAssessOption_03(HandleRef pThis);

		public virtual bool GetAssessOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetAssessOption_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStatisticsAlgorithm_GetAssessParameters_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetAssessParameters()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetAssessParameters_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStatisticsAlgorithm_GetColumnForRequest_05(HandleRef pThis, long r, long c);

		public virtual string GetColumnForRequest(long r, long c)
		{
			return Marshal.PtrToStringAnsi(vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetColumnForRequest_05(base.GetCppThis(), r, c));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStatisticsAlgorithm_GetDeriveOption_06(HandleRef pThis);

		public virtual bool GetDeriveOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetDeriveOption_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStatisticsAlgorithm_GetLearnOption_07(HandleRef pThis);

		public virtual bool GetLearnOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetLearnOption_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_08(HandleRef pThis, long request);

		public virtual long GetNumberOfColumnsForRequest(long request)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_08(base.GetCppThis(), request);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_09(HandleRef pThis);

		public virtual long GetNumberOfPrimaryTables()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfRequests_10(HandleRef pThis);

		public virtual long GetNumberOfRequests()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfRequests_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkStatisticsAlgorithm_GetTestOption_11(HandleRef pThis);

		public virtual bool GetTestOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetTestOption_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStatisticsAlgorithm_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStatisticsAlgorithm_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStatisticsAlgorithm_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStatisticsAlgorithm NewInstance()
		{
			vtkStatisticsAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStatisticsAlgorithm_RequestSelectedColumns_15(HandleRef pThis);

		public virtual int RequestSelectedColumns()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_RequestSelectedColumns_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_ResetAllColumnStates_16(HandleRef pThis);

		public virtual void ResetAllColumnStates()
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_ResetAllColumnStates_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_ResetRequests_17(HandleRef pThis);

		public virtual void ResetRequests()
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_ResetRequests_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStatisticsAlgorithm_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStatisticsAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkStatisticsAlgorithm vtkStatisticsAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStatisticsAlgorithm = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStatisticsAlgorithm.Register(null);
				}
			}
			return vtkStatisticsAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetAssessNames_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetAssessNames(vtkStringArray arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetAssessNames_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetAssessOption_20(HandleRef pThis, byte _arg);

		public virtual void SetAssessOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetAssessOption_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetAssessParameters_21(HandleRef pThis, HandleRef arg0);

		public virtual void SetAssessParameters(vtkStringArray arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetAssessParameters_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetColumnStatus_22(HandleRef pThis, string namCol, int status);

		public virtual void SetColumnStatus(string namCol, int status)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetColumnStatus_22(base.GetCppThis(), namCol, status);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetDeriveOption_23(HandleRef pThis, byte _arg);

		public virtual void SetDeriveOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetDeriveOption_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetInputModel_24(HandleRef pThis, HandleRef model);

		public virtual void SetInputModel(vtkDataObject model)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetInputModel_24(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetInputModelConnection_25(HandleRef pThis, HandleRef model);

		public virtual void SetInputModelConnection(vtkAlgorithmOutput model)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetInputModelConnection_25(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOption_26(HandleRef pThis, byte _arg);

		public virtual void SetLearnOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOption_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_27(HandleRef pThis, HandleRef arg0);

		public virtual void SetLearnOptionParameterConnection(vtkAlgorithmOutput arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameters_28(HandleRef pThis, HandleRef arg0);

		public virtual void SetLearnOptionParameters(vtkDataObject arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOptionParameters_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_29(HandleRef pThis, long _arg);

		public virtual void SetNumberOfPrimaryTables(long _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStatisticsAlgorithm_SetTestOption_30(HandleRef pThis, byte _arg);

		public virtual void SetTestOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetTestOption_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
