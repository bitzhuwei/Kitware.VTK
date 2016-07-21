using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVRMLExporter : vtkExporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMLExporter";

		public new static readonly string MRClassNameKey;

		static vtkVRMLExporter()
		{
			vtkVRMLExporter.MRClassNameKey = "class vtkVRMLExporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMLExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMLExporter"));
		}

		public vtkVRMLExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVRMLExporter New()
		{
			vtkVRMLExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVRMLExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVRMLExporter.vtkVRMLExporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLExporter_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkVRMLExporter.vtkVRMLExporter_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVRMLExporter_GetSpeed_02(HandleRef pThis);

		public virtual double GetSpeed()
		{
			return vtkVRMLExporter.vtkVRMLExporter_GetSpeed_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVRMLExporter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVRMLExporter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVRMLExporter.vtkVRMLExporter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLExporter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVRMLExporter NewInstance()
		{
			vtkVRMLExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLExporter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVRMLExporter SafeDownCast(vtkObjectBase o)
		{
			vtkVRMLExporter vtkVRMLExporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLExporter.vtkVRMLExporter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMLExporter = (vtkVRMLExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMLExporter.Register(null);
				}
			}
			return vtkVRMLExporter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVRMLExporter_SetFileName_08(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkVRMLExporter.vtkVRMLExporter_SetFileName_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVRMLExporter_SetSpeed_09(HandleRef pThis, double _arg);

		public virtual void SetSpeed(double _arg)
		{
			vtkVRMLExporter.vtkVRMLExporter_SetSpeed_09(base.GetCppThis(), _arg);
		}
	}
}
