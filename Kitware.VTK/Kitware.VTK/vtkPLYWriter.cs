using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPLYWriter : vtkPolyDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLYWriter";

		public new static readonly string MRClassNameKey;

		static vtkPLYWriter()
		{
			vtkPLYWriter.MRClassNameKey = "class vtkPLYWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLYWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYWriter"));
		}

		public vtkPLYWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLYWriter New()
		{
			vtkPLYWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPLYWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPLYWriter.vtkPLYWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_GetArrayName_01(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPLYWriter.vtkPLYWriter_GetArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_GetColor_02(HandleRef pThis);

		public virtual byte[] GetColor()
		{
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetColor_02(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_GetColor_03(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

		public virtual void GetColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
		{
			vtkPLYWriter.vtkPLYWriter_GetColor_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_GetColor_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetColor(IntPtr _arg)
		{
			vtkPLYWriter.vtkPLYWriter_GetColor_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetColorMode_05(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkPLYWriter.vtkPLYWriter_GetColorMode_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetComponent_06(HandleRef pThis);

		public virtual int GetComponent()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponent_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetComponentMaxValue_07(HandleRef pThis);

		public virtual int GetComponentMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponentMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetComponentMinValue_08(HandleRef pThis);

		public virtual int GetComponentMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetComponentMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetDataByteOrder_09(HandleRef pThis);

		public virtual int GetDataByteOrder()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrder_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetDataByteOrderMaxValue_10(HandleRef pThis);

		public virtual int GetDataByteOrderMaxValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrderMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_GetDataByteOrderMinValue_11(HandleRef pThis);

		public virtual int GetDataByteOrderMinValue()
		{
			return vtkPLYWriter.vtkPLYWriter_GetDataByteOrderMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_GetLookupTable_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_GetLookupTable_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYWriter_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPLYWriter.vtkPLYWriter_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPLYWriter NewInstance()
		{
			vtkPLYWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYWriter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLYWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPLYWriter vtkPLYWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYWriter.vtkPLYWriter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLYWriter = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLYWriter.Register(null);
				}
			}
			return vtkPLYWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetArrayName_18(HandleRef pThis, string _arg);

		public virtual void SetArrayName(string _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetArrayName_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColor_19(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

		public virtual void SetColor(byte _arg1, byte _arg2, byte _arg3)
		{
			vtkPLYWriter.vtkPLYWriter_SetColor_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColor_20(HandleRef pThis, IntPtr _arg);

		public virtual void SetColor(IntPtr _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetColor_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorMode_21(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetColorMode_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorModeToDefault_22(HandleRef pThis);

		public void SetColorModeToDefault()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToDefault_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorModeToOff_23(HandleRef pThis);

		public void SetColorModeToOff()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorModeToUniformCellColor_24(HandleRef pThis);

		public void SetColorModeToUniformCellColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformCellColor_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorModeToUniformColor_25(HandleRef pThis);

		public void SetColorModeToUniformColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformColor_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetColorModeToUniformPointColor_26(HandleRef pThis);

		public void SetColorModeToUniformPointColor()
		{
			vtkPLYWriter.vtkPLYWriter_SetColorModeToUniformPointColor_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetComponent_27(HandleRef pThis, int _arg);

		public virtual void SetComponent(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetComponent_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetDataByteOrder_28(HandleRef pThis, int _arg);

		public virtual void SetDataByteOrder(int _arg)
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrder_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetDataByteOrderToBigEndian_29(HandleRef pThis);

		public void SetDataByteOrderToBigEndian()
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrderToBigEndian_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetDataByteOrderToLittleEndian_30(HandleRef pThis);

		public void SetDataByteOrderToLittleEndian()
		{
			vtkPLYWriter.vtkPLYWriter_SetDataByteOrderToLittleEndian_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYWriter_SetLookupTable_31(HandleRef pThis, HandleRef arg0);

		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkPLYWriter.vtkPLYWriter_SetLookupTable_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
