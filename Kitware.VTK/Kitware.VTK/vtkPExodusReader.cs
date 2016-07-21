using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPExodusReader : vtkExodusReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExodusReader";

		public new static readonly string MRClassNameKey;

		static vtkPExodusReader()
		{
			vtkPExodusReader.MRClassNameKey = "class vtkPExodusReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExodusReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExodusReader"));
		}

		public vtkPExodusReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExodusReader New()
		{
			vtkPExodusReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusReader.vtkPExodusReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPExodusReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPExodusReader.vtkPExodusReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilter_01(HandleRef pThis, HandleRef a_filter);

		public new void AddFilter(vtkDSPFilterDefinition a_filter)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilter_01(base.GetCppThis(), (a_filter == null) ? default(HandleRef) : a_filter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilterDenominatorWeight_02(HandleRef pThis, double weight);

		public new void AddFilterDenominatorWeight(double weight)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilterDenominatorWeight_02(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilterForwardNumeratorWeight_03(HandleRef pThis, double weight);

		public new void AddFilterForwardNumeratorWeight(double weight)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilterForwardNumeratorWeight_03(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilterInputVar_04(HandleRef pThis, string name);

		public new void AddFilterInputVar(string name)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilterInputVar_04(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilterNumeratorWeight_05(HandleRef pThis, double weight);

		public new void AddFilterNumeratorWeight(double weight)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilterNumeratorWeight_05(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_AddFilterOutputVar_06(HandleRef pThis, string name);

		public new void AddFilterOutputVar(string name)
		{
			vtkPExodusReader.vtkPExodusReader_AddFilterOutputVar_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_EnableDSPFiltering_07(HandleRef pThis);

		public new void EnableDSPFiltering()
		{
			vtkPExodusReader.vtkPExodusReader_EnableDSPFiltering_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_FinishAddingFilter_08(HandleRef pThis);

		public new void FinishAddingFilter()
		{
			vtkPExodusReader.vtkPExodusReader_FinishAddingFilter_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_GenerateFileIdArrayOff_09(HandleRef pThis);

		public virtual void GenerateFileIdArrayOff()
		{
			vtkPExodusReader.vtkPExodusReader_GenerateFileIdArrayOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_GenerateFileIdArrayOn_10(HandleRef pThis);

		public virtual void GenerateFileIdArrayOn()
		{
			vtkPExodusReader.vtkPExodusReader_GenerateFileIdArrayOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_GetFilePattern_11(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkPExodusReader.vtkPExodusReader_GetFilePattern_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_GetFilePrefix_12(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkPExodusReader.vtkPExodusReader_GetFilePrefix_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_GetFileRange_13(HandleRef pThis);

		public virtual int[] GetFileRange()
		{
			IntPtr intPtr = vtkPExodusReader.vtkPExodusReader_GetFileRange_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_GetFileRange_14(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetFileRange(ref int _arg1, ref int _arg2)
		{
			vtkPExodusReader.vtkPExodusReader_GetFileRange_14(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_GetFileRange_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetFileRange(IntPtr _arg)
		{
			vtkPExodusReader.vtkPExodusReader_GetFileRange_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetGenerateFileIdArray_16(HandleRef pThis);

		public virtual int GetGenerateFileIdArray()
		{
			return vtkPExodusReader.vtkPExodusReader_GetGenerateFileIdArray_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetNumberOfFileNames_17(HandleRef pThis);

		public int GetNumberOfFileNames()
		{
			return vtkPExodusReader.vtkPExodusReader_GetNumberOfFileNames_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetNumberOfFiles_18(HandleRef pThis);

		public virtual int GetNumberOfFiles()
		{
			return vtkPExodusReader.vtkPExodusReader_GetNumberOfFiles_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetNumberOfVariableArrays_19(HandleRef pThis);

		public new int GetNumberOfVariableArrays()
		{
			return vtkPExodusReader.vtkPExodusReader_GetNumberOfVariableArrays_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetTotalNumberOfElements_20(HandleRef pThis);

		public override int GetTotalNumberOfElements()
		{
			return vtkPExodusReader.vtkPExodusReader_GetTotalNumberOfElements_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_GetTotalNumberOfNodes_21(HandleRef pThis);

		public override int GetTotalNumberOfNodes()
		{
			return vtkPExodusReader.vtkPExodusReader_GetTotalNumberOfNodes_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_GetVariableArrayName_22(HandleRef pThis, int a_which);

		public new string GetVariableArrayName(int a_which)
		{
			return Marshal.PtrToStringAnsi(vtkPExodusReader.vtkPExodusReader_GetVariableArrayName_22(base.GetCppThis(), a_which));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPExodusReader.vtkPExodusReader_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPExodusReader_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPExodusReader.vtkPExodusReader_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPExodusReader NewInstance()
		{
			vtkPExodusReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusReader.vtkPExodusReader_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_RemoveFilter_27(HandleRef pThis, string a_outputVariableName);

		public new void RemoveFilter(string a_outputVariableName)
		{
			vtkPExodusReader.vtkPExodusReader_RemoveFilter_27(base.GetCppThis(), a_outputVariableName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPExodusReader_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExodusReader SafeDownCast(vtkObjectBase o)
		{
			vtkPExodusReader vtkPExodusReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExodusReader.vtkPExodusReader_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExodusReader = (vtkPExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExodusReader.Register(null);
				}
			}
			return vtkPExodusReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetFileName_29(HandleRef pThis, string name);

		public override void SetFileName(string name)
		{
			vtkPExodusReader.vtkPExodusReader_SetFileName_29(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetFilePattern_30(HandleRef pThis, string _arg);

		public virtual void SetFilePattern(string _arg)
		{
			vtkPExodusReader.vtkPExodusReader_SetFilePattern_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetFilePrefix_31(HandleRef pThis, string _arg);

		public virtual void SetFilePrefix(string _arg)
		{
			vtkPExodusReader.vtkPExodusReader_SetFilePrefix_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetFileRange_32(HandleRef pThis, int arg0, int arg1);

		public void SetFileRange(int arg0, int arg1)
		{
			vtkPExodusReader.vtkPExodusReader_SetFileRange_32(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetFileRange_33(HandleRef pThis, IntPtr r);

		public void SetFileRange(IntPtr r)
		{
			vtkPExodusReader.vtkPExodusReader_SetFileRange_33(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_SetGenerateFileIdArray_34(HandleRef pThis, int flag);

		public void SetGenerateFileIdArray(int flag)
		{
			vtkPExodusReader.vtkPExodusReader_SetGenerateFileIdArray_34(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPExodusReader_StartAddingFilter_35(HandleRef pThis);

		public new void StartAddingFilter()
		{
			vtkPExodusReader.vtkPExodusReader_StartAddingFilter_35(base.GetCppThis());
		}
	}
}
