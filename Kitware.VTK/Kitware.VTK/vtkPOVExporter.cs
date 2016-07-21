using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPOVExporter : vtkExporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOVExporter";

		public new static readonly string MRClassNameKey;

		static vtkPOVExporter()
		{
			vtkPOVExporter.MRClassNameKey = "class vtkPOVExporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOVExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOVExporter"));
		}

		public vtkPOVExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPOVExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOVExporter New()
		{
			vtkPOVExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPOVExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPOVExporter.vtkPOVExporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPOVExporter_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPOVExporter.vtkPOVExporter_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPOVExporter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPOVExporter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPOVExporter.vtkPOVExporter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPOVExporter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPOVExporter NewInstance()
		{
			vtkPOVExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPOVExporter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOVExporter SafeDownCast(vtkObjectBase o)
		{
			vtkPOVExporter vtkPOVExporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOVExporter.vtkPOVExporter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOVExporter = (vtkPOVExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOVExporter.Register(null);
				}
			}
			return vtkPOVExporter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPOVExporter_SetFileName_07(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkPOVExporter.vtkPOVExporter_SetFileName_07(base.GetCppThis(), _arg);
		}
	}
}
