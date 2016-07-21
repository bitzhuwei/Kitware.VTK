using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPLYReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLYReader";

		public new static readonly string MRClassNameKey;

		static vtkPLYReader()
		{
			vtkPLYReader.MRClassNameKey = "class vtkPLYReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLYReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYReader"));
		}

		public vtkPLYReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLYReader New()
		{
			vtkPLYReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPLYReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPLYReader.vtkPLYReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkPLYReader.vtkPLYReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPLYReader.vtkPLYReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPLYReader.vtkPLYReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLYReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPLYReader.vtkPLYReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPLYReader NewInstance()
		{
			vtkPLYReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLYReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLYReader SafeDownCast(vtkObjectBase o)
		{
			vtkPLYReader vtkPLYReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLYReader = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLYReader.Register(null);
				}
			}
			return vtkPLYReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLYReader_SetFileName_08(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkPLYReader.vtkPLYReader_SetFileName_08(base.GetCppThis(), _arg);
		}
	}
}
