using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPDBReader : vtkMoleculeReaderBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDBReader";

		public new static readonly string MRClassNameKey;

		static vtkPDBReader()
		{
			vtkPDBReader.MRClassNameKey = "class vtkPDBReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDBReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDBReader"));
		}

		public vtkPDBReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPDBReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDBReader New()
		{
			vtkPDBReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPDBReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPDBReader.vtkPDBReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPDBReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPDBReader.vtkPDBReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPDBReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPDBReader.vtkPDBReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPDBReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPDBReader NewInstance()
		{
			vtkPDBReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPDBReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDBReader SafeDownCast(vtkObjectBase o)
		{
			vtkPDBReader vtkPDBReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDBReader = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDBReader.Register(null);
				}
			}
			return vtkPDBReader;
		}
	}
}
