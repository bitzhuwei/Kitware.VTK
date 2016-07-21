using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPUnstructuredGridWriter : vtkXMLPUnstructuredDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredGridWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPUnstructuredGridWriter()
		{
			vtkXMLPUnstructuredGridWriter.MRClassNameKey = "class vtkXMLPUnstructuredGridWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredGridWriter"));
		}

		public vtkXMLPUnstructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPUnstructuredGridWriter New()
		{
			vtkXMLPUnstructuredGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPUnstructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredGridWriter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredGridWriter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPUnstructuredGridWriter NewInstance()
		{
			vtkXMLPUnstructuredGridWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredGridWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPUnstructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredGridWriter vtkXMLPUnstructuredGridWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredGridWriter.vtkXMLPUnstructuredGridWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredGridWriter = (vtkXMLPUnstructuredGridWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredGridWriter.Register(null);
				}
			}
			return vtkXMLPUnstructuredGridWriter;
		}
	}
}
