using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBMPReader : vtkImageReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBMPReader";

		public new static readonly string MRClassNameKey;

		static vtkBMPReader()
		{
			vtkBMPReader.MRClassNameKey = "class vtkBMPReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBMPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBMPReader"));
		}

		public vtkBMPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBMPReader New()
		{
			vtkBMPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBMPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBMPReader.vtkBMPReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBMPReader_Allow8BitBMPOff_01(HandleRef pThis);

		public virtual void Allow8BitBMPOff()
		{
			vtkBMPReader.vtkBMPReader_Allow8BitBMPOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBMPReader_Allow8BitBMPOn_02(HandleRef pThis);

		public virtual void Allow8BitBMPOn()
		{
			vtkBMPReader.vtkBMPReader_Allow8BitBMPOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBMPReader_CanReadFile_03(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkBMPReader.vtkBMPReader_CanReadFile_03(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBMPReader_GetAllow8BitBMP_04(HandleRef pThis);

		public virtual int GetAllow8BitBMP()
		{
			return vtkBMPReader.vtkBMPReader_GetAllow8BitBMP_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_GetColors_05(HandleRef pThis);

		public virtual IntPtr GetColors()
		{
			return vtkBMPReader.vtkBMPReader_GetColors_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBMPReader_GetDepth_06(HandleRef pThis);

		public virtual int GetDepth()
		{
			return vtkBMPReader.vtkBMPReader_GetDepth_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_GetDescriptiveName_07(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkBMPReader.vtkBMPReader_GetDescriptiveName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_GetFileExtensions_08(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkBMPReader.vtkBMPReader_GetFileExtensions_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_GetLookupTable_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_GetLookupTable_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBMPReader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBMPReader.vtkBMPReader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBMPReader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBMPReader.vtkBMPReader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBMPReader NewInstance()
		{
			vtkBMPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBMPReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBMPReader SafeDownCast(vtkObjectBase o)
		{
			vtkBMPReader vtkBMPReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBMPReader = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBMPReader.Register(null);
				}
			}
			return vtkBMPReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBMPReader_SetAllow8BitBMP_15(HandleRef pThis, int _arg);

		public virtual void SetAllow8BitBMP(int _arg)
		{
			vtkBMPReader.vtkBMPReader_SetAllow8BitBMP_15(base.GetCppThis(), _arg);
		}
	}
}
