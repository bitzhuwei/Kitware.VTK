using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphReader : vtkDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphReader";

		public new static readonly string MRClassNameKey;

		static vtkGraphReader()
		{
			vtkGraphReader.MRClassNameKey = "class vtkGraphReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphReader"));
		}

		public vtkGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphReader New()
		{
			vtkGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphReader.vtkGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphReader.vtkGraphReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphReader_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphReader.vtkGraphReader_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphReader_GetOutput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetOutput(int idx)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphReader.vtkGraphReader_GetOutput_02(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGraphReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphReader.vtkGraphReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGraphReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphReader.vtkGraphReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphReader NewInstance()
		{
			vtkGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphReader.vtkGraphReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkGraphReader vtkGraphReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphReader.vtkGraphReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphReader = (vtkGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphReader.Register(null);
				}
			}
			return vtkGraphReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGraphReader_SetOutput_08(HandleRef pThis, HandleRef output);

		public void SetOutput(vtkGraph output)
		{
			vtkGraphReader.vtkGraphReader_SetOutput_08(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}
	}
}
