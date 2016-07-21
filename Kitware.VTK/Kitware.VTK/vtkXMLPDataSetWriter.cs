using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPDataSetWriter : vtkXMLPDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataSetWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPDataSetWriter()
		{
			vtkXMLPDataSetWriter.MRClassNameKey = "class vtkXMLPDataSetWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataSetWriter"));
		}

		public vtkXMLPDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPDataSetWriter New()
		{
			vtkXMLPDataSetWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataSetWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataSetWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataSetWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataSetWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPDataSetWriter NewInstance()
		{
			vtkXMLPDataSetWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataSetWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataSetWriter vtkXMLPDataSetWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataSetWriter = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataSetWriter.Register(null);
				}
			}
			return vtkXMLPDataSetWriter;
		}
	}
}
