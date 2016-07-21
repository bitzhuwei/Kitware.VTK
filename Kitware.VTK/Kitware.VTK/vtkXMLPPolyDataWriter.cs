using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPPolyDataWriter : vtkXMLPUnstructuredDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPPolyDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPPolyDataWriter()
		{
			vtkXMLPPolyDataWriter.MRClassNameKey = "class vtkXMLPPolyDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPPolyDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPPolyDataWriter"));
		}

		public vtkXMLPPolyDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPPolyDataWriter New()
		{
			vtkXMLPPolyDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPPolyDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPPolyDataWriter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPPolyDataWriter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPPolyDataWriter NewInstance()
		{
			vtkXMLPPolyDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPPolyDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPPolyDataWriter vtkXMLPPolyDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataWriter.vtkXMLPPolyDataWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPPolyDataWriter = (vtkXMLPPolyDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPPolyDataWriter.Register(null);
				}
			}
			return vtkXMLPPolyDataWriter;
		}
	}
}
