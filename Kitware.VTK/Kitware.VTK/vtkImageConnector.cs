using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageConnector : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConnector";

		public new static readonly string MRClassNameKey;

		static vtkImageConnector()
		{
			vtkImageConnector.MRClassNameKey = "class vtkImageConnector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConnector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConnector"));
		}

		public vtkImageConnector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConnector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConnector New()
		{
			vtkImageConnector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageConnector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageConnector.vtkImageConnector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern byte vtkImageConnector_GetConnectedValue_01(HandleRef pThis);

		public virtual byte GetConnectedValue()
		{
			return vtkImageConnector.vtkImageConnector_GetConnectedValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern byte vtkImageConnector_GetUnconnectedValue_02(HandleRef pThis);

		public virtual byte GetUnconnectedValue()
		{
			return vtkImageConnector.vtkImageConnector_GetUnconnectedValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConnector_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageConnector.vtkImageConnector_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConnector_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageConnector.vtkImageConnector_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConnector_MarkData_05(HandleRef pThis, HandleRef data, int dimensionality, IntPtr ext);

		public void MarkData(vtkImageData data, int dimensionality, IntPtr ext)
		{
			vtkImageConnector.vtkImageConnector_MarkData_05(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), dimensionality, ext);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConnector_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageConnector NewInstance()
		{
			vtkImageConnector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConnector_RemoveAllSeeds_08(HandleRef pThis);

		public void RemoveAllSeeds()
		{
			vtkImageConnector.vtkImageConnector_RemoveAllSeeds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConnector_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConnector SafeDownCast(vtkObjectBase o)
		{
			vtkImageConnector vtkImageConnector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConnector.vtkImageConnector_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConnector = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConnector.Register(null);
				}
			}
			return vtkImageConnector;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConnector_SetConnectedValue_10(HandleRef pThis, byte _arg);

		public virtual void SetConnectedValue(byte _arg)
		{
			vtkImageConnector.vtkImageConnector_SetConnectedValue_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConnector_SetUnconnectedValue_11(HandleRef pThis, byte _arg);

		public virtual void SetUnconnectedValue(byte _arg)
		{
			vtkImageConnector.vtkImageConnector_SetUnconnectedValue_11(base.GetCppThis(), _arg);
		}
	}
}
