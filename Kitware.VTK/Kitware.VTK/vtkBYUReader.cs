using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBYUReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBYUReader";

		public new static readonly string MRClassNameKey;

		static vtkBYUReader()
		{
			vtkBYUReader.MRClassNameKey = "class vtkBYUReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBYUReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUReader"));
		}

		public vtkBYUReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBYUReader New()
		{
			vtkBYUReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBYUReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBYUReader.vtkBYUReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkBYUReader.vtkBYUReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_GetDisplacementFileName_02(HandleRef pThis);

		public virtual string GetDisplacementFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetDisplacementFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_GetGeometryFileName_04(HandleRef pThis);

		public virtual string GetGeometryFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetGeometryFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetPartNumber_05(HandleRef pThis);

		public virtual int GetPartNumber()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumber_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetPartNumberMaxValue_06(HandleRef pThis);

		public virtual int GetPartNumberMaxValue()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumberMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetPartNumberMinValue_07(HandleRef pThis);

		public virtual int GetPartNumberMinValue()
		{
			return vtkBYUReader.vtkBYUReader_GetPartNumberMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetReadDisplacement_08(HandleRef pThis);

		public virtual int GetReadDisplacement()
		{
			return vtkBYUReader.vtkBYUReader_GetReadDisplacement_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetReadScalar_09(HandleRef pThis);

		public virtual int GetReadScalar()
		{
			return vtkBYUReader.vtkBYUReader_GetReadScalar_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_GetReadTexture_10(HandleRef pThis);

		public virtual int GetReadTexture()
		{
			return vtkBYUReader.vtkBYUReader_GetReadTexture_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_GetScalarFileName_11(HandleRef pThis);

		public virtual string GetScalarFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetScalarFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_GetTextureFileName_12(HandleRef pThis);

		public virtual string GetTextureFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUReader.vtkBYUReader_GetTextureFileName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBYUReader.vtkBYUReader_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUReader_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBYUReader.vtkBYUReader_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBYUReader NewInstance()
		{
			vtkBYUReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadDisplacementOff_17(HandleRef pThis);

		public virtual void ReadDisplacementOff()
		{
			vtkBYUReader.vtkBYUReader_ReadDisplacementOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadDisplacementOn_18(HandleRef pThis);

		public virtual void ReadDisplacementOn()
		{
			vtkBYUReader.vtkBYUReader_ReadDisplacementOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadScalarOff_19(HandleRef pThis);

		public virtual void ReadScalarOff()
		{
			vtkBYUReader.vtkBYUReader_ReadScalarOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadScalarOn_20(HandleRef pThis);

		public virtual void ReadScalarOn()
		{
			vtkBYUReader.vtkBYUReader_ReadScalarOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadTextureOff_21(HandleRef pThis);

		public virtual void ReadTextureOff()
		{
			vtkBYUReader.vtkBYUReader_ReadTextureOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_ReadTextureOn_22(HandleRef pThis);

		public virtual void ReadTextureOn()
		{
			vtkBYUReader.vtkBYUReader_ReadTextureOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUReader_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBYUReader SafeDownCast(vtkObjectBase o)
		{
			vtkBYUReader vtkBYUReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUReader.vtkBYUReader_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBYUReader = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBYUReader.Register(null);
				}
			}
			return vtkBYUReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetDisplacementFileName_24(HandleRef pThis, string _arg);

		public virtual void SetDisplacementFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetDisplacementFileName_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetFileName_25(HandleRef pThis, string f);

		public virtual void SetFileName(string f)
		{
			vtkBYUReader.vtkBYUReader_SetFileName_25(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetGeometryFileName_26(HandleRef pThis, string _arg);

		public virtual void SetGeometryFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetGeometryFileName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetPartNumber_27(HandleRef pThis, int _arg);

		public virtual void SetPartNumber(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetPartNumber_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetReadDisplacement_28(HandleRef pThis, int _arg);

		public virtual void SetReadDisplacement(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadDisplacement_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetReadScalar_29(HandleRef pThis, int _arg);

		public virtual void SetReadScalar(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadScalar_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetReadTexture_30(HandleRef pThis, int _arg);

		public virtual void SetReadTexture(int _arg)
		{
			vtkBYUReader.vtkBYUReader_SetReadTexture_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetScalarFileName_31(HandleRef pThis, string _arg);

		public virtual void SetScalarFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetScalarFileName_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUReader_SetTextureFileName_32(HandleRef pThis, string _arg);

		public virtual void SetTextureFileName(string _arg)
		{
			vtkBYUReader.vtkBYUReader_SetTextureFileName_32(base.GetCppThis(), _arg);
		}
	}
}
