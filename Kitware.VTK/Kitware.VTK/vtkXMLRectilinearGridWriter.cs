using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLRectilinearGridWriter : vtkXMLStructuredDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLRectilinearGridWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLRectilinearGridWriter()
		{
			vtkXMLRectilinearGridWriter.MRClassNameKey = "class vtkXMLRectilinearGridWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLRectilinearGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLRectilinearGridWriter"));
		}

		public vtkXMLRectilinearGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLRectilinearGridWriter New()
		{
			vtkXMLRectilinearGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLRectilinearGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGrid GetInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLRectilinearGridWriter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLRectilinearGridWriter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLRectilinearGridWriter NewInstance()
		{
			vtkXMLRectilinearGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLRectilinearGridWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLRectilinearGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLRectilinearGridWriter vtkXMLRectilinearGridWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLRectilinearGridWriter.vtkXMLRectilinearGridWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLRectilinearGridWriter = (vtkXMLRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLRectilinearGridWriter.Register(null);
				}
			}
			return vtkXMLRectilinearGridWriter;
		}
	}
}
