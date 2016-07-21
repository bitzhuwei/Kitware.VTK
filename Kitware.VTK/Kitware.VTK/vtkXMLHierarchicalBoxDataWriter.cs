using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLHierarchicalBoxDataWriter : vtkXMLCompositeDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLHierarchicalBoxDataWriter()
		{
			vtkXMLHierarchicalBoxDataWriter.MRClassNameKey = "class vtkXMLHierarchicalBoxDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalBoxDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataWriter"));
		}

		public vtkXMLHierarchicalBoxDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalBoxDataWriter New()
		{
			vtkXMLHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLHierarchicalBoxDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalBoxDataWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalBoxDataWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLHierarchicalBoxDataWriter NewInstance()
		{
			vtkXMLHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalBoxDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalBoxDataWriter vtkXMLHierarchicalBoxDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalBoxDataWriter = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalBoxDataWriter.Register(null);
				}
			}
			return vtkXMLHierarchicalBoxDataWriter;
		}
	}
}
