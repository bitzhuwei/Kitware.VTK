using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLStructuredGridWriter : vtkXMLStructuredDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredGridWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLStructuredGridWriter()
		{
			vtkXMLStructuredGridWriter.MRClassNameKey = "class vtkXMLStructuredGridWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredGridWriter"));
		}

		public vtkXMLStructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLStructuredGridWriter New()
		{
			vtkXMLStructuredGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLStructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredGridWriter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredGridWriter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredGridWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLStructuredGridWriter NewInstance()
		{
			vtkXMLStructuredGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredGridWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLStructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredGridWriter vtkXMLStructuredGridWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredGridWriter.vtkXMLStructuredGridWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredGridWriter = (vtkXMLStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredGridWriter.Register(null);
				}
			}
			return vtkXMLStructuredGridWriter;
		}
	}
}
