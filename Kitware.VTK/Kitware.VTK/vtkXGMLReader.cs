using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXGMLReader : vtkUndirectedGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXGMLReader";

		public new static readonly string MRClassNameKey;

		static vtkXGMLReader()
		{
			vtkXGMLReader.MRClassNameKey = "class vtkXGMLReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXGMLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXGMLReader"));
		}

		public vtkXGMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXGMLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXGMLReader New()
		{
			vtkXGMLReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXGMLReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXGMLReader.vtkXGMLReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXGMLReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXGMLReader.vtkXGMLReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkXGMLReader_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkXGMLReader_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXGMLReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXGMLReader NewInstance()
		{
			vtkXGMLReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXGMLReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXGMLReader SafeDownCast(vtkObjectBase o)
		{
			vtkXGMLReader vtkXGMLReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXGMLReader = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXGMLReader.Register(null);
				}
			}
			return vtkXGMLReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXGMLReader_SetFileName_07(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkXGMLReader.vtkXGMLReader_SetFileName_07(base.GetCppThis(), _arg);
		}
	}
}
