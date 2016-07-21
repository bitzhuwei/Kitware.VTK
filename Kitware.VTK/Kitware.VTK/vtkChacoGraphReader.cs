using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChacoGraphReader : vtkUndirectedGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChacoGraphReader";

		public new static readonly string MRClassNameKey;

		static vtkChacoGraphReader()
		{
			vtkChacoGraphReader.MRClassNameKey = "class vtkChacoGraphReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChacoGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChacoGraphReader"));
		}

		public vtkChacoGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChacoGraphReader New()
		{
			vtkChacoGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChacoGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChacoGraphReader.vtkChacoGraphReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoGraphReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkChacoGraphReader.vtkChacoGraphReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkChacoGraphReader_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkChacoGraphReader_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChacoGraphReader.vtkChacoGraphReader_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoGraphReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChacoGraphReader NewInstance()
		{
			vtkChacoGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoGraphReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChacoGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkChacoGraphReader vtkChacoGraphReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoGraphReader.vtkChacoGraphReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChacoGraphReader = (vtkChacoGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChacoGraphReader.Register(null);
				}
			}
			return vtkChacoGraphReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkChacoGraphReader_SetFileName_07(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkChacoGraphReader.vtkChacoGraphReader_SetFileName_07(base.GetCppThis(), _arg);
		}
	}
}
