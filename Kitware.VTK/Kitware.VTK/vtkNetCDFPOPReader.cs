using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNetCDFPOPReader : vtkRectilinearGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFPOPReader";

		public new static readonly string MRClassNameKey;

		static vtkNetCDFPOPReader()
		{
			vtkNetCDFPOPReader.MRClassNameKey = "class vtkNetCDFPOPReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFPOPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFPOPReader"));
		}

		public vtkNetCDFPOPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFPOPReader New()
		{
			vtkNetCDFPOPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNetCDFPOPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNetCDFPOPReader.vtkNetCDFPOPReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFPOPReader_GetNumberOfVariableArrays_02(HandleRef pThis);

		public virtual int GetNumberOfVariableArrays()
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetNumberOfVariableArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_GetStride_03(HandleRef pThis);

		public virtual int[] GetStride()
		{
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_GetStride_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetStride(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_GetStride_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetStride(IntPtr _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_GetVariableArrayName_06(HandleRef pThis, int idx);

		public virtual string GetVariableArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetVariableArrayName_06(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFPOPReader_GetVariableArrayStatus_07(HandleRef pThis, string name);

		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetVariableArrayStatus_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFPOPReader_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkNetCDFPOPReader_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNetCDFPOPReader NewInstance()
		{
			vtkNetCDFPOPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkNetCDFPOPReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetCDFPOPReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFPOPReader vtkNetCDFPOPReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFPOPReader = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFPOPReader.Register(null);
				}
			}
			return vtkNetCDFPOPReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_SetFileName_13(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetFileName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_SetStride_14(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetStride(int _arg1, int _arg2, int _arg3)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetStride_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_SetStride_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetStride(IntPtr _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetStride_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkNetCDFPOPReader_SetVariableArrayStatus_16(HandleRef pThis, string name, int status);

		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetVariableArrayStatus_16(base.GetCppThis(), name, status);
		}
	}
}
