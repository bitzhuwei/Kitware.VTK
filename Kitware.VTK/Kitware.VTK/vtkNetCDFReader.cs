using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNetCDFReader : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFReader";

		public new static readonly string MRClassNameKey;

		static vtkNetCDFReader()
		{
			vtkNetCDFReader.MRClassNameKey = "class vtkNetCDFReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFReader"));
		}

		public vtkNetCDFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFReader New()
		{
			vtkNetCDFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNetCDFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNetCDFReader.vtkNetCDFReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_GetAllDimensions_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetAllDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetAllDimensions_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_GetAllVariableArrayNames_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetAllVariableArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetAllVariableArrayNames_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_GetNumberOfVariableArrays_04(HandleRef pThis);

		public virtual int GetNumberOfVariableArrays()
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetNumberOfVariableArrays_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_GetReplaceFillValueWithNan_05(HandleRef pThis);

		public virtual int GetReplaceFillValueWithNan()
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetReplaceFillValueWithNan_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_GetVariableArrayName_06(HandleRef pThis, int idx);

		public virtual string GetVariableArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkNetCDFReader.vtkNetCDFReader_GetVariableArrayName_06(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_GetVariableArrayStatus_07(HandleRef pThis, string name);

		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkNetCDFReader.vtkNetCDFReader_GetVariableArrayStatus_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_GetVariableDimensions_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetVariableDimensions()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_GetVariableDimensions_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFReader.vtkNetCDFReader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNetCDFReader NewInstance()
		{
			vtkNetCDFReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOff_13(HandleRef pThis);

		public virtual void ReplaceFillValueWithNanOff()
		{
			vtkNetCDFReader.vtkNetCDFReader_ReplaceFillValueWithNanOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOn_14(HandleRef pThis);

		public virtual void ReplaceFillValueWithNanOn()
		{
			vtkNetCDFReader.vtkNetCDFReader_ReplaceFillValueWithNanOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFReader vtkNetCDFReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFReader.vtkNetCDFReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFReader = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFReader.Register(null);
				}
			}
			return vtkNetCDFReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_SetDimensions_16(HandleRef pThis, string dimensions);

		public virtual void SetDimensions(string dimensions)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetDimensions_16(base.GetCppThis(), dimensions);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_SetFileName_17(HandleRef pThis, string filename);

		public virtual void SetFileName(string filename)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetFileName_17(base.GetCppThis(), filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_SetReplaceFillValueWithNan_18(HandleRef pThis, int _arg);

		public virtual void SetReplaceFillValueWithNan(int _arg)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetReplaceFillValueWithNan_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFReader_SetVariableArrayStatus_19(HandleRef pThis, string name, int status);

		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkNetCDFReader.vtkNetCDFReader_SetVariableArrayStatus_19(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFReader_UpdateMetaData_20(HandleRef pThis);

		public int UpdateMetaData()
		{
			return vtkNetCDFReader.vtkNetCDFReader_UpdateMetaData_20(base.GetCppThis());
		}
	}
}
