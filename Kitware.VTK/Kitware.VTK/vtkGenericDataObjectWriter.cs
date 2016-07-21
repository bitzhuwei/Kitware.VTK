using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericDataObjectWriter : vtkDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataObjectWriter";

		public new static readonly string MRClassNameKey;

		static vtkGenericDataObjectWriter()
		{
			vtkGenericDataObjectWriter.MRClassNameKey = "class vtkGenericDataObjectWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataObjectWriter"));
		}

		public vtkGenericDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataObjectWriter New()
		{
			vtkGenericDataObjectWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericDataObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericDataObjectWriter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericDataObjectWriter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataObjectWriter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericDataObjectWriter NewInstance()
		{
			vtkGenericDataObjectWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataObjectWriter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataObjectWriter vtkGenericDataObjectWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataObjectWriter = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataObjectWriter.Register(null);
				}
			}
			return vtkGenericDataObjectWriter;
		}
	}
}
