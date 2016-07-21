using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParticleReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParticleReader";

		public new static readonly string MRClassNameKey;

		static vtkParticleReader()
		{
			vtkParticleReader.MRClassNameKey = "class vtkParticleReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParticleReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleReader"));
		}

		public vtkParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParticleReader New()
		{
			vtkParticleReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParticleReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParticleReader.vtkParticleReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetDataByteOrder_01(HandleRef pThis);

		public int GetDataByteOrder()
		{
			return vtkParticleReader.vtkParticleReader_GetDataByteOrder_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkParticleReader_GetDataByteOrderAsString_02(HandleRef pThis);

		public string GetDataByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkParticleReader.vtkParticleReader_GetDataByteOrderAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetDataType_03(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkParticleReader.vtkParticleReader_GetDataType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetDataTypeMaxValue_04(HandleRef pThis);

		public virtual int GetDataTypeMaxValue()
		{
			return vtkParticleReader.vtkParticleReader_GetDataTypeMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetDataTypeMinValue_05(HandleRef pThis);

		public virtual int GetDataTypeMinValue()
		{
			return vtkParticleReader.vtkParticleReader_GetDataTypeMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkParticleReader_GetFileName_06(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkParticleReader.vtkParticleReader_GetFileName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetFileType_07(HandleRef pThis);

		public virtual int GetFileType()
		{
			return vtkParticleReader.vtkParticleReader_GetFileType_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetFileTypeMaxValue_08(HandleRef pThis);

		public virtual int GetFileTypeMaxValue()
		{
			return vtkParticleReader.vtkParticleReader_GetFileTypeMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetFileTypeMinValue_09(HandleRef pThis);

		public virtual int GetFileTypeMinValue()
		{
			return vtkParticleReader.vtkParticleReader_GetFileTypeMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetHasScalar_10(HandleRef pThis);

		public virtual int GetHasScalar()
		{
			return vtkParticleReader.vtkParticleReader_GetHasScalar_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_GetSwapBytes_11(HandleRef pThis);

		public int GetSwapBytes()
		{
			return vtkParticleReader.vtkParticleReader_GetSwapBytes_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_HasScalarOff_12(HandleRef pThis);

		public virtual void HasScalarOff()
		{
			vtkParticleReader.vtkParticleReader_HasScalarOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_HasScalarOn_13(HandleRef pThis);

		public virtual void HasScalarOn()
		{
			vtkParticleReader.vtkParticleReader_HasScalarOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParticleReader.vtkParticleReader_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkParticleReader_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParticleReader.vtkParticleReader_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkParticleReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParticleReader NewInstance()
		{
			vtkParticleReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkParticleReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParticleReader SafeDownCast(vtkObjectBase o)
		{
			vtkParticleReader vtkParticleReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParticleReader = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParticleReader.Register(null);
				}
			}
			return vtkParticleReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataByteOrder_19(HandleRef pThis, int arg0);

		public void SetDataByteOrder(int arg0)
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrder_19(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataByteOrderToBigEndian_20(HandleRef pThis);

		public void SetDataByteOrderToBigEndian()
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrderToBigEndian_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataByteOrderToLittleEndian_21(HandleRef pThis);

		public void SetDataByteOrderToLittleEndian()
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrderToLittleEndian_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataType_22(HandleRef pThis, int _arg);

		public virtual void SetDataType(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetDataType_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataTypeToDouble_23(HandleRef pThis);

		public void SetDataTypeToDouble()
		{
			vtkParticleReader.vtkParticleReader_SetDataTypeToDouble_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetDataTypeToFloat_24(HandleRef pThis);

		public void SetDataTypeToFloat()
		{
			vtkParticleReader.vtkParticleReader_SetDataTypeToFloat_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetFileName_25(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkParticleReader.vtkParticleReader_SetFileName_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetFileType_26(HandleRef pThis, int _arg);

		public virtual void SetFileType(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetFileType_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetFileTypeToBinary_27(HandleRef pThis);

		public void SetFileTypeToBinary()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToBinary_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetFileTypeToText_28(HandleRef pThis);

		public void SetFileTypeToText()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToText_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetFileTypeToUnknown_29(HandleRef pThis);

		public void SetFileTypeToUnknown()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToUnknown_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetHasScalar_30(HandleRef pThis, int _arg);

		public virtual void SetHasScalar(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetHasScalar_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SetSwapBytes_31(HandleRef pThis, int _arg);

		public virtual void SetSwapBytes(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetSwapBytes_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SwapBytesOff_32(HandleRef pThis);

		public virtual void SwapBytesOff()
		{
			vtkParticleReader.vtkParticleReader_SwapBytesOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkParticleReader_SwapBytesOn_33(HandleRef pThis);

		public virtual void SwapBytesOn()
		{
			vtkParticleReader.vtkParticleReader_SwapBytesOn_33(base.GetCppThis());
		}
	}
}
